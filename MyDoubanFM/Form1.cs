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
        private readonly NetEase _netEase = new NetEase();
        private QQMusic _qqMusic;

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            _qqMusic = new QQMusic(webBrowserQQ);
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
            _netEase.Stop();
            if (rdbQQ.Checked)
            {
                _qqMusic.Play(name, tbxUid.Text, tbxVer.Text, tbxMinVer.Text);
                SaveSettings();
            }
            else
            {
                _netEase.Player = axWindowsMediaPlayerNet;
                //如果网易没有源则使用qq音乐
                if (!_netEase.Play(name)) 
                    _qqMusic.Play(name, tbxUid.Text, tbxVer.Text, tbxMinVer.Text);
            }
            
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
