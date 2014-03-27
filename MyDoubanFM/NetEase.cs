using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using AxWMPLib;
using Newtonsoft.Json.Linq;

namespace MyDoubanFM
{
    class NetEase
    {
        private const string SearchUrl = "http://music.163.com/api/search/pc";
        public AxWindowsMediaPlayer Player;
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
                JToken jt = jo["songs"].First["hMusic"];
                Debug.WriteLine(jt);
                string dfsId = (string) jt["dfsId"];
                string extension = (string) jt["extension"];
                string encryptPath = EncryptId(dfsId);
                string url = string.Format("http://m2.music.126.net/{0}/{1}.{2}", encryptPath, dfsId, extension);
                return url;
            }
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
    }
}
