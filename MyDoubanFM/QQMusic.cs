using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using mshtml;

namespace MyDoubanFM
{
    class QQMusic
    {
        private const string SosoUrlPre = "http://soso.music.qq.com/fcgi-bin/music3_new.fcg?p=1&catZhida=1&t=100&portal=client&searchid=1828052434720886076&remoteplace=txt.client.top&utf8=1&w=";
       
        private readonly WebBrowser _browser;
        private bool _isPlayed;

        public QQMusic(WebBrowser browser)
        {
            _browser = browser;
            _browser.DocumentCompleted += webBrowserQQ_DocumentCompleted;
            
        }

        public void Play(string name, string uid, string qver, string qmver)
        {
            string searchurl = SosoUrlPre + HttpUtility.UrlEncode(name);
            SetQQMusicCookie(searchurl,uid,qver,qmver);
            _browser.Navigate(searchurl);
            _isPlayed = false;
        }
        private void webBrowserQQ_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            string url = _browser.Url.ToString();
            if (url.StartsWith("http://soso.music.qq.com"))
            {
                HtmlElement head = _browser.Document.GetElementsByTagName("head")[0];
                HtmlElement scriptEl = _browser.Document.CreateElement("script");
                var element = (IHTMLScriptElement)scriptEl.DomElement;
                element.text = @"function myPlay(){g_player.play(document.getElementsByClassName('btn_play')[0])}";
                head.AppendChild(scriptEl);
                if (!_isPlayed)
                {
                    _browser.Document.InvokeScript("myPlay");
                    _isPlayed = true;
                    //webBrowserMain.Document.InvokeScript("myPause");
                }
            }
        }


        [DllImport("wininet.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool InternetSetCookie(string lpszUrlName, string lbszCookieName, string lpszCookieData);

        /// <summary>
        /// 设置QQ搜索的必要cookie
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        private void SetQQMusicCookie(string url,string uid, string qver, string qmver)
        {
            InternetSetCookie(url, "ts_uid", uid);
            InternetSetCookie(url, "qqmusic_version", qver);
            InternetSetCookie(url, "qqmusic_miniversion", qmver);
        }


    }
}
