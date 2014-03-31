using System;
using System.Diagnostics;
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
        private NetEase _netEase;
        private QQMusic _qqMusic;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _qqMusic = new QQMusic(webBrowserQQ);
            _netEase = new NetEase(axWindowsMediaPlayerNet);
            webBrowserMain.ObjectForScripting = this;
            tbxUid.Text = Properties.Settings.Default.Uid;
            tbxVer.Text = Properties.Settings.Default.QVer;
            tbxMinVer.Text = Properties.Settings.Default.QMinVer;
            tbxMusicU.Text = Properties.Settings.Default.MusicU;
            tbxPid.Text = Properties.Settings.Default.Pid;
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

    function myLike(){
        DBR.act('love');
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
            //            string song = (string)jo["songName"];
            //            string artist = (string)jo["artistName"];
            string song = "50 Ways To Say Goodbye";
            string artist = "Train";
            this.Text = song + " - " + artist;
            _netEase.Stop();
            _qqMusic.Search(rdbQQ.Checked, song + " " + artist, tbxUid.Text, tbxVer.Text, tbxMinVer.Text);
            _netEase.Search(song, artist, tbxMusicU.Text);
            ShowNetResult();
            if (rdbNet.Checked)
            {
                //如果网易没有源则使用qq音乐
                if (!_netEase.Play())
                    _qqMusic.Play();
            }
            SaveSettings();
            tbxLog.Text = "";
        }

        private void ShowNetResult()
        {
            lsbNetSongs.Items.Clear();
            lsbNetSongs.Items.AddRange(_netEase.GetResults());
        }

        private void SaveSettings()
        {
            Properties.Settings.Default.Uid = tbxUid.Text;
            Properties.Settings.Default.QVer = tbxVer.Text;
            Properties.Settings.Default.QMinVer = tbxMinVer.Text;
            Properties.Settings.Default.MusicU = tbxMusicU.Text;
            Properties.Settings.Default.Pid = tbxPid.Text;
            Properties.Settings.Default.Save();
        }


        private void btnLike_Click(object sender, EventArgs e)
        {
            if (cbxNet.Checked)
            {
                tbxLog.Text = _netEase.Like(tbxMusicU.Text, tbxPid.Text);
            }
            if (cbxDouban.Checked)
            {
                webBrowserMain.Document.InvokeScript("myLike");
            }
        }

        private void lsbNetSongs_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = lsbNetSongs.IndexFromPoint(e.Location);
            if (index > -1)
            {
                _netEase.Play(index);
            }
        }

    }
}
