using System;
using System.Runtime.InteropServices;
using System.Web;
using System.Windows.Forms;
using mshtml;
using Newtonsoft.Json.Linq;

namespace MyDoubanFM
{
    [ComVisible(true)]
    public partial class Form1 : Form
    {
        private const string SosoUrlPre = "http://soso.music.qq.com/fcgi-bin/music3_new.fcg?p=1&catZhida=1&t=100&portal=client&searchid=1828052434720886076&remoteplace=txt.client.top&utf8=1&w=";
        private bool _isPlayed;

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            webBrowserMain.ObjectForScripting = this;
            tbxUid.Text = Properties.Settings.Default.Uid;
            tbxVer.Text = Properties.Settings.Default.QVer;
            tbxMinVer.Text = Properties.Settings.Default.QMinVer;
        }

        private void webBrowserMain_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            HtmlElement head = webBrowserMain.Document.GetElementsByTagName("head")[0];
            HtmlElement scriptEl = webBrowserMain.Document.CreateElement("script");
            var element = (IHTMLScriptElement)scriptEl.DomElement;
            element.text = @"function test(q) {
        window.external.ParseSoundInfo(JSON.stringify(q));
    }
  
    function show(x, z) {
        var k = {songName: x, artistName: z || ''};
        test(k);
    }

    function addFM(){
        if (!window.FM){
            window.FM = {setCurrentSongInfo:show};
        }else{
            window.FM.setCurrentSongInfo = show;
        }
    }

/*
    var myInt = setInterval(function () {
        if (window.FM) {
            FM.setCurrentSongInfo = show;
            clearInterval(myInt);
        }
    }, 100);'
*/";
            head.AppendChild(scriptEl);
            webBrowserMain.Document.InvokeScript("addFM");
        }

        public void ParseSoundInfo(string o)
        {
            /*       Root: {
              "songName": "The Truth That You Leave",
              "artistName": "Piano Boy",
              "channelName": "私人兆赫",
              "url": "http://douban.fm/?start=1812646g317ag0&cid=3812646",
              "curl": "http://douban.fm/?cid=0",
              "type": "私人兆赫",
              "coverUrl": "http://img5.douban.com/lpic/s4435637.jpg",
              "id": "1812646",
              "ssid": "317a"}  */
            //webBrowserMain.Document.InvokeScript("myPause");
            JObject jo = JObject.Parse(o);
            string name = jo["songName"] + " " + jo["artistName"];
            this.Text = jo["songName"] + " - " + jo["artistName"];
            string searchurl = SosoUrlPre + HttpUtility.UrlEncode(name);
            SetQqMusicCookie(searchurl);
            webBrowserQQ.Navigate(searchurl);
            _isPlayed = false;
        }

        private void webBrowserQQ_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            string url = webBrowserQQ.Url.ToString();
            if (url.StartsWith("http://soso.music.qq.com"))
            {
                HtmlElement head = webBrowserQQ.Document.GetElementsByTagName("head")[0];
                HtmlElement scriptEl = webBrowserQQ.Document.CreateElement("script");
                var element = (IHTMLScriptElement)scriptEl.DomElement;
                element.text = @"function myPlay(){g_player.play(document.getElementsByClassName('btn_play')[0])}";
                head.AppendChild(scriptEl);
                if (!_isPlayed)
                {
                    webBrowserQQ.Document.InvokeScript("myPlay");
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
        private string SetQqMusicCookie(string url)
        {
            string cookie = textBoxCookie.Text;
            InternetSetCookie(url, "ts_uid", tbxUid.Text);
            InternetSetCookie(url, "qqmusic_version", tbxVer.Text);
            InternetSetCookie(url, "qqmusic_miniversion", tbxMinVer.Text);
            SaveSettings();
            return cookie;
        }

        private void SaveSettings()
        {
            Properties.Settings.Default.Uid = tbxUid.Text;
            Properties.Settings.Default.QVer = tbxVer.Text;
            Properties.Settings.Default.QMinVer = tbxMinVer.Text;
            Properties.Settings.Default.Save();
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
        }

       





        
    }
}
