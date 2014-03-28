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
        public AxWindowsMediaPlayer Player;
        private string _nowSongId;
        public bool Play(string name)
        {
            string resJson = Search(name);
            string mp3Url = ParseResult(resJson);
            if (!string.IsNullOrWhiteSpace(mp3Url))
            {
                Player.URL = mp3Url;
                Player.Ctlcontrols.play();
                return true;
            }
            return false;
        }

        public void Stop()
        {
            try
            {
                Player.Ctlcontrols.pause();
            }
            catch
            {
                
            }
            
        }

        private string Search(string searchstr)
        {
            HttpWebRequest req = WebRequest.CreateHttp(SearchUrl);
            req.Method = "POST";
            req.CookieContainer = new CookieContainer();
            req.CookieContainer.Add(new Uri(SearchUrl),new Cookie("os","pc"));
            req.ContentType = "application/x-www-form-urlencoded";
            using (Stream postStream = req.GetRequestStream())
            {

                byte[] postBytes = new ASCIIEncoding().GetBytes("offset=0&total=true&limit=100&type=1&s=" + HttpUtility.UrlEncode(searchstr));
                postStream.Write(postBytes, 0, postBytes.Length);
            }
            using (var reader = new StreamReader(req.GetResponse().GetResponseStream()))
            {
                return reader.ReadToEnd();
            }
        }

        private string ParseResult(string resJson)
        {
            JObject jo = (JObject) JObject.Parse(resJson)["result"];

            if ((int)jo["songCount"] > 0)
            {
                JToken song = jo["songs"].First;
                Debug.WriteLine(song);
                _nowSongId = (string) song["id"];
                JToken jt = song["hMusic"];
                string dfsId = (string) jt["dfsId"];
                string extension = (string) jt["extension"];
                string encryptPath = EncryptId(dfsId);
                string url = string.Format("http://m2.music.126.net/{0}/{1}.{2}", encryptPath, dfsId, extension);
                return url;
            }
            _nowSongId = null;
            return null;
        }

        private string EncryptId(string dfsId)
        {
            ASCIIEncoding encoding = new ASCIIEncoding();
            byte[] bytes1 = encoding.GetBytes("3go8&$8*3*3h0k(2)2");
            byte[] bytes2 = encoding.GetBytes(dfsId);
            for (int i = 0; i < bytes2.Length; i++)
                bytes2[i] = (byte) (bytes2[i] ^ bytes1[i%bytes1.Length]);
            using (MD5 md5Hash = MD5.Create())
            {
                string res = Convert.ToBase64String(md5Hash.ComputeHash(bytes2));
                res = res.Replace('/', '_').Replace('+', '-');
                return res;
            }
        }




        public string Like(string musicu,string pid) 
        {
            if (!string.IsNullOrWhiteSpace(_nowSongId))
            {
                return PlistOpr(true, musicu, pid, _nowSongId);
            }
            return null;
        }

        private static string PlistOpr(bool isLike,string musicu,string pid,string sid)
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
