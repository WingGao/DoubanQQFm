using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using AxWMPLib;
using Newtonsoft.Json.Linq;

namespace MyDoubanFM
{
    class NetEase
    {
        private const string MainUrl = "http://music.163.com";
        private const string SearchUrl = MainUrl + "/api/search/pc";
        private const string PlistManipulate = MainUrl + "/api/playlist/manipulate/tracks";
        private readonly AxWindowsMediaPlayer _player;
        private string _nowSongId;
        private JToken _resultJToken;
        private bool _secondSearch = false;

        public NetEase(AxWindowsMediaPlayer player)
        {
            _player = player;
            _player.settings.volume = 100;

        }
        public bool Play()
        {
            if (GetResultsCount() > 0)
            {
                Play(0);
                return true;
            }
            return false;
        }

        public void Play(int index)
        {
            JToken song = _resultJToken["songs"][index];
            string url320 = GetMusic320(song);
            _player.URL = string.IsNullOrWhiteSpace(url320) ? GetMusic96(song) : url320;
            _player.Ctlcontrols.play();
        }


        public void Stop()
        {
            try
            {
                _player.Ctlcontrols.pause();
            }
            catch
            {

            }

        }

        public void Search(string name, string artist, string musicu)
        {
            HttpWebRequest req = WebRequest.CreateHttp(SearchUrl);
            req.Method = "POST";
            req.CookieContainer = new CookieContainer();
            req.CookieContainer.Add(new Uri(SearchUrl), new Cookie("os", "pc"));
            req.CookieContainer.Add(new Uri(SearchUrl), new Cookie("MUSIC_U", musicu));
            req.ContentType = "application/x-www-form-urlencoded";
            using (Stream postStream = req.GetRequestStream())
            {

                byte[] postBytes = new ASCIIEncoding().GetBytes("offset=0&total=true&limit=100&type=1&s=" + HttpUtility.UrlEncode((name + " " + artist).Trim()));
                postStream.Write(postBytes, 0, postBytes.Length);
            }
            using (var reader = new StreamReader(req.GetResponse().GetResponseStream()))
            {
                ParseResult(reader.ReadToEnd());
                if (GetResultsCount() == 0 && !_secondSearch)
                {
                    _secondSearch = true;
                    Search(name, "", musicu);
                }
                else _secondSearch = false;
            }
        }

        private void ParseResult(string resJson)
        {
            _resultJToken = JObject.Parse(resJson)["result"];
        }

        private int GetResultsCount()
        {
            return (int)_resultJToken["songCount"];
        }

        public string[] GetResults()
        {
            if (GetResultsCount() > 0)
                return
                    _resultJToken["songs"].Select(
                        t =>
                            string.Format("{0} - {1} - 《{2}》", t["name"], t["artists"][0]["name"],
                                t["album"]["name"]))
                        .ToArray();
            return new string[0];
        }

        private string GetMusic320(JToken song)
        {
            Debug.WriteLine(song);
            _nowSongId = (string)song["id"];
            JToken hToken = song["hMusic"];
            if (hToken.Type != JTokenType.Null)
            {
                string dfsId = (string)hToken["dfsId"];
                string extension = (string)hToken["extension"];
                string encryptPath = EncryptId(dfsId);
                string url = string.Format("http://m2.music.126.net/{0}/{1}.{2}", encryptPath, dfsId, extension);
                return url;
            }
            return null;
        }

        private string GetMusic96(JToken song)
        {
            return (string)song["mp3Url"];
        }

        private string EncryptId(string dfsId)
        {
            ASCIIEncoding encoding = new ASCIIEncoding();
            byte[] bytes1 = encoding.GetBytes("3go8&$8*3*3h0k(2)2");
            byte[] bytes2 = encoding.GetBytes(dfsId);
            for (int i = 0; i < bytes2.Length; i++)
                bytes2[i] = (byte)(bytes2[i] ^ bytes1[i % bytes1.Length]);
            using (MD5 md5Hash = MD5.Create())
            {
                string res = Convert.ToBase64String(md5Hash.ComputeHash(bytes2));
                res = res.Replace('/', '_').Replace('+', '-');
                return res;
            }
        }

        public string Like(string musicu, string pid)
        {
            if (!string.IsNullOrWhiteSpace(_nowSongId))
            {
                return PlistOpr(true, musicu, pid, _nowSongId);
            }
            return null;
        }

        private static string PlistOpr(bool isLike, string musicu, string pid, string sid)
        {
            HttpWebRequest req = WebRequest.CreateHttp(PlistManipulate);
            req.Method = "POST";
            req.CookieContainer = new CookieContainer();
            req.CookieContainer.Add(new Uri(PlistManipulate), new Cookie("os", "pc"));
            req.CookieContainer.Add(new Uri(PlistManipulate), new Cookie("MUSIC_U", musicu));
            req.ContentType = "application/x-www-form-urlencoded";
            using (Stream postStream = req.GetRequestStream())
            {

                byte[] postBytes = new ASCIIEncoding().GetBytes(string.Format("trackIds=%5B{0}%5D&pid={1}&op={2}",
                    sid, pid, isLike ? "add" : "del"));
                postStream.Write(postBytes, 0, postBytes.Length);
            }
            using (var reader = new StreamReader(req.GetResponse().GetResponseStream()))
            {
                return reader.ReadToEnd();
            }
        }

    }
}
