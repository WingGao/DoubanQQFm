namespace MyDoubanFM
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.webBrowserMain = new System.Windows.Forms.WebBrowser();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tbxMinVer = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxVer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxUid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.webBrowserQQ = new System.Windows.Forms.WebBrowser();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.axWindowsMediaPlayerNet = new AxWMPLib.AxWindowsMediaPlayer();
            this.groupBoxSource = new System.Windows.Forms.GroupBox();
            this.rdbNet = new System.Windows.Forms.RadioButton();
            this.rdbQQ = new System.Windows.Forms.RadioButton();
            this.tbxMusicU = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnLike = new System.Windows.Forms.Button();
            this.tbxLog = new System.Windows.Forms.TextBox();
            this.tbxPid = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxDouban = new System.Windows.Forms.CheckBox();
            this.cbxNet = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabControlMain.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayerNet)).BeginInit();
            this.groupBoxSource.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // webBrowserMain
            // 
            this.webBrowserMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowserMain.Location = new System.Drawing.Point(6, 6);
            this.webBrowserMain.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserMain.Name = "webBrowserMain";
            this.webBrowserMain.ScriptErrorsSuppressed = true;
            this.webBrowserMain.Size = new System.Drawing.Size(944, 362);
            this.webBrowserMain.TabIndex = 0;
            this.webBrowserMain.Url = new System.Uri("http://douban.fm/", System.UriKind.Absolute);
            this.webBrowserMain.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowserMain_DocumentCompleted);
            // 
            // tabControlMain
            // 
            this.tabControlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlMain.Controls.Add(this.tabPage1);
            this.tabControlMain.Controls.Add(this.tabPage2);
            this.tabControlMain.Controls.Add(this.tabPage3);
            this.tabControlMain.Location = new System.Drawing.Point(12, 12);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(914, 400);
            this.tabControlMain.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.webBrowserMain);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(906, 374);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "DoubanFM";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tbxMinVer);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.tbxVer);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.tbxUid);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.webBrowserQQ);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(906, 374);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "QQMusic";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tbxMinVer
            // 
            this.tbxMinVer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxMinVer.Location = new System.Drawing.Point(793, 57);
            this.tbxMinVer.Name = "tbxMinVer";
            this.tbxMinVer.Size = new System.Drawing.Size(100, 21);
            this.tbxMinVer.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(716, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 12);
            this.label3.TabIndex = 14;
            this.label3.Text = "miniversion";
            // 
            // tbxVer
            // 
            this.tbxVer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxVer.Location = new System.Drawing.Point(793, 30);
            this.tbxVer.Name = "tbxVer";
            this.tbxVer.Size = new System.Drawing.Size(100, 21);
            this.tbxVer.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(716, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 12;
            this.label2.Text = "version";
            // 
            // tbxUid
            // 
            this.tbxUid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxUid.Location = new System.Drawing.Point(793, 3);
            this.tbxUid.Name = "tbxUid";
            this.tbxUid.Size = new System.Drawing.Size(100, 21);
            this.tbxUid.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(716, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 10;
            this.label1.Text = "ts_uid";
            // 
            // webBrowserQQ
            // 
            this.webBrowserQQ.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowserQQ.Location = new System.Drawing.Point(6, 6);
            this.webBrowserQQ.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserQQ.Name = "webBrowserQQ";
            this.webBrowserQQ.ScriptErrorsSuppressed = true;
            this.webBrowserQQ.Size = new System.Drawing.Size(704, 362);
            this.webBrowserQQ.TabIndex = 0;
            this.webBrowserQQ.Url = new System.Uri("http://music.qq.com/midportal/musichall/#ctime=1395799690.206", System.UriKind.Absolute);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.tbxPid);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.tbxMusicU);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.axWindowsMediaPlayerNet);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(906, 374);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "网易云音乐";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // axWindowsMediaPlayerNet
            // 
            this.axWindowsMediaPlayerNet.Enabled = true;
            this.axWindowsMediaPlayerNet.Location = new System.Drawing.Point(3, 3);
            this.axWindowsMediaPlayerNet.Name = "axWindowsMediaPlayerNet";
            this.axWindowsMediaPlayerNet.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayerNet.OcxState")));
            this.axWindowsMediaPlayerNet.Size = new System.Drawing.Size(568, 143);
            this.axWindowsMediaPlayerNet.TabIndex = 0;
            // 
            // groupBoxSource
            // 
            this.groupBoxSource.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxSource.Controls.Add(this.rdbNet);
            this.groupBoxSource.Controls.Add(this.rdbQQ);
            this.groupBoxSource.Location = new System.Drawing.Point(932, 12);
            this.groupBoxSource.Name = "groupBoxSource";
            this.groupBoxSource.Size = new System.Drawing.Size(198, 73);
            this.groupBoxSource.TabIndex = 4;
            this.groupBoxSource.TabStop = false;
            this.groupBoxSource.Text = "音源";
            // 
            // rdbNet
            // 
            this.rdbNet.AutoSize = true;
            this.rdbNet.Checked = true;
            this.rdbNet.Location = new System.Drawing.Point(6, 41);
            this.rdbNet.Name = "rdbNet";
            this.rdbNet.Size = new System.Drawing.Size(119, 16);
            this.rdbNet.TabIndex = 1;
            this.rdbNet.TabStop = true;
            this.rdbNet.Text = "网易云音乐(320k)";
            this.rdbNet.UseVisualStyleBackColor = true;
            // 
            // rdbQQ
            // 
            this.rdbQQ.AutoSize = true;
            this.rdbQQ.Location = new System.Drawing.Point(6, 19);
            this.rdbQQ.Name = "rdbQQ";
            this.rdbQQ.Size = new System.Drawing.Size(155, 16);
            this.rdbQQ.TabIndex = 0;
            this.rdbQQ.Text = "QQ音乐（需安装客户端）";
            this.rdbQQ.UseVisualStyleBackColor = true;
            // 
            // tbxMusicU
            // 
            this.tbxMusicU.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxMusicU.Location = new System.Drawing.Point(778, 16);
            this.tbxMusicU.Name = "tbxMusicU";
            this.tbxMusicU.Size = new System.Drawing.Size(125, 21);
            this.tbxMusicU.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(725, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 12);
            this.label4.TabIndex = 12;
            this.label4.Text = "MUSIC_U";
            // 
            // btnLike
            // 
            this.btnLike.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLike.Location = new System.Drawing.Point(6, 71);
            this.btnLike.Name = "btnLike";
            this.btnLike.Size = new System.Drawing.Size(75, 23);
            this.btnLike.TabIndex = 14;
            this.btnLike.Text = "喜欢";
            this.btnLike.UseVisualStyleBackColor = true;
            this.btnLike.Click += new System.EventHandler(this.btnLike_Click);
            // 
            // tbxLog
            // 
            this.tbxLog.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxLog.Location = new System.Drawing.Point(964, 221);
            this.tbxLog.Multiline = true;
            this.tbxLog.Name = "tbxLog";
            this.tbxLog.Size = new System.Drawing.Size(166, 191);
            this.tbxLog.TabIndex = 15;
            // 
            // tbxPid
            // 
            this.tbxPid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxPid.Location = new System.Drawing.Point(778, 43);
            this.tbxPid.Name = "tbxPid";
            this.tbxPid.Size = new System.Drawing.Size(125, 21);
            this.tbxPid.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(725, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 12);
            this.label5.TabIndex = 14;
            this.label5.Text = "pid";
            // 
            // cbxDouban
            // 
            this.cbxDouban.AutoSize = true;
            this.cbxDouban.Checked = true;
            this.cbxDouban.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxDouban.Location = new System.Drawing.Point(6, 20);
            this.cbxDouban.Name = "cbxDouban";
            this.cbxDouban.Size = new System.Drawing.Size(48, 16);
            this.cbxDouban.TabIndex = 16;
            this.cbxDouban.Text = "豆瓣";
            this.cbxDouban.UseVisualStyleBackColor = true;
            // 
            // cbxNet
            // 
            this.cbxNet.AutoSize = true;
            this.cbxNet.Checked = true;
            this.cbxNet.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxNet.Location = new System.Drawing.Point(60, 20);
            this.cbxNet.Name = "cbxNet";
            this.cbxNet.Size = new System.Drawing.Size(48, 16);
            this.cbxNet.TabIndex = 17;
            this.cbxNet.Text = "网易";
            this.cbxNet.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbxNet);
            this.groupBox1.Controls.Add(this.btnLike);
            this.groupBox1.Controls.Add(this.cbxDouban);
            this.groupBox1.Location = new System.Drawing.Point(932, 91);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "喜欢";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 421);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbxLog);
            this.Controls.Add(this.groupBoxSource);
            this.Controls.Add(this.tabControlMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "豆瓣+QQ电台 - by WingGao";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControlMain.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayerNet)).EndInit();
            this.groupBoxSource.ResumeLayout(false);
            this.groupBoxSource.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowserMain;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.WebBrowser webBrowserQQ;
        private System.Windows.Forms.TextBox tbxMinVer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxVer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxUid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxSource;
        private System.Windows.Forms.RadioButton rdbNet;
        private System.Windows.Forms.RadioButton rdbQQ;
        private System.Windows.Forms.TabPage tabPage3;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayerNet;
        private System.Windows.Forms.TextBox tbxMusicU;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnLike;
        private System.Windows.Forms.TextBox tbxLog;
        private System.Windows.Forms.TextBox tbxPid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox cbxDouban;
        private System.Windows.Forms.CheckBox cbxNet;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

