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
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxCookie = new System.Windows.Forms.TextBox();
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
            this.tabControlMain.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayerNet)).BeginInit();
            this.groupBoxSource.SuspendLayout();
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
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(1055, 227);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxCookie
            // 
            this.textBoxCookie.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCookie.Location = new System.Drawing.Point(1002, 256);
            this.textBoxCookie.Multiline = true;
            this.textBoxCookie.Name = "textBoxCookie";
            this.textBoxCookie.Size = new System.Drawing.Size(128, 153);
            this.textBoxCookie.TabIndex = 2;
            this.textBoxCookie.Text = "alert(\'hello\')";
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
            this.tabPage1.Size = new System.Drawing.Size(961, 374);
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
            this.tabPage2.Size = new System.Drawing.Size(961, 374);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "QQMusic";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tbxMinVer
            // 
            this.tbxMinVer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxMinVer.Location = new System.Drawing.Point(855, 60);
            this.tbxMinVer.Name = "tbxMinVer";
            this.tbxMinVer.Size = new System.Drawing.Size(100, 21);
            this.tbxMinVer.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(778, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 12);
            this.label3.TabIndex = 14;
            this.label3.Text = "miniversion";
            // 
            // tbxVer
            // 
            this.tbxVer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxVer.Location = new System.Drawing.Point(855, 33);
            this.tbxVer.Name = "tbxVer";
            this.tbxVer.Size = new System.Drawing.Size(100, 21);
            this.tbxVer.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(778, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 12;
            this.label2.Text = "version";
            // 
            // tbxUid
            // 
            this.tbxUid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxUid.Location = new System.Drawing.Point(855, 6);
            this.tbxUid.Name = "tbxUid";
            this.tbxUid.Size = new System.Drawing.Size(100, 21);
            this.tbxUid.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(778, 9);
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
            this.webBrowserQQ.Size = new System.Drawing.Size(747, 362);
            this.webBrowserQQ.TabIndex = 0;
            this.webBrowserQQ.Url = new System.Uri("http://music.qq.com/midportal/musichall/#ctime=1395799690.206", System.UriKind.Absolute);
            // 
            // tabPage3
            // 
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
            this.groupBoxSource.Location = new System.Drawing.Point(964, 12);
            this.groupBoxSource.Name = "groupBoxSource";
            this.groupBoxSource.Size = new System.Drawing.Size(166, 73);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 421);
            this.Controls.Add(this.groupBoxSource);
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.textBoxCookie);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "豆瓣+QQ电台 - by WingGao";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControlMain.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayerNet)).EndInit();
            this.groupBoxSource.ResumeLayout(false);
            this.groupBoxSource.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowserMain;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxCookie;
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
    }
}

