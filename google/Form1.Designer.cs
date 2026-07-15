namespace google
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            txtSearch = new Button();
            btnSearch = new TextBox();
            lstResults = new ListBox();
            label1 = new Label();
            G = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            menuStrip1 = new MenuStrip();
            圖片ToolStripMenuItem = new ToolStripMenuItem();
            地圖ToolStripMenuItem = new ToolStripMenuItem();
            新聞ToolStripMenuItem = new ToolStripMenuItem();
            翻譯ToolStripMenuItem = new ToolStripMenuItem();
            gmailToolStripMenuItem = new ToolStripMenuItem();
            更多ToolStripMenuItem = new ToolStripMenuItem();
            硬碟ToolStripMenuItem = new ToolStripMenuItem();
            youtubeToolStripMenuItem = new ToolStripMenuItem();
            紀錄ToolStripMenuItem = new ToolStripMenuItem();
            搜尋紀錄ToolStripMenuItem = new ToolStripMenuItem();
            紀錄HToolStripMenuItem = new ToolStripMenuItem();
            登入ToolStripMenuItem = new ToolStripMenuItem();
            geminiToolStripMenuItem = new ToolStripMenuItem();
            URL = new TextBox();
            button1 = new Button();
            button2 = new Button();
            panel1 = new Panel();
            label7 = new Label();
            button4 = new Button();
            add = new Button();
            panel2 = new Panel();
            webViewChrome = new Microsoft.Web.WebView2.WinForms.WebView2();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)webViewChrome).BeginInit();
            SuspendLayout();
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(587, 187);
            txtSearch.Margin = new Padding(5);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(71, 37);
            txtSearch.TabIndex = 0;
            txtSearch.Text = "搜尋";
            txtSearch.UseVisualStyleBackColor = true;
            txtSearch.Click += txtSearch_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(128, 187);
            btnSearch.Margin = new Padding(5);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(463, 30);
            btnSearch.TabIndex = 1;
            btnSearch.TextChanged += btnSearch_TextChanged;
            // 
            // lstResults
            // 
            lstResults.FormattingEnabled = true;
            lstResults.Location = new Point(128, 216);
            lstResults.Margin = new Padding(5);
            lstResults.Name = "lstResults";
            lstResults.Size = new Size(463, 372);
            lstResults.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label1.Location = new Point(272, 593);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(143, 30);
            label1.TabIndex = 4;
            label1.Text = "搜尋紀錄(&H)";
            label1.Click += label1_Click;
            // 
            // G
            // 
            G.AutoSize = true;
            G.Font = new Font("Microsoft JhengHei UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 136);
            G.ForeColor = Color.Blue;
            G.Location = new Point(203, 80);
            G.Margin = new Padding(5, 0, 5, 0);
            G.Name = "G";
            G.Size = new Size(92, 91);
            G.TabIndex = 5;
            G.Text = "G";
            G.Click += G_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(272, 80);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(84, 91);
            label2.TabIndex = 6;
            label2.Text = "o";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft JhengHei UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label3.ForeColor = Color.Yellow;
            label3.Location = new Point(332, 80);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(84, 91);
            label3.TabIndex = 7;
            label3.Text = "o";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft JhengHei UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label4.ForeColor = Color.Blue;
            label4.Location = new Point(398, 80);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(85, 91);
            label4.TabIndex = 8;
            label4.Text = "g";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft JhengHei UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label5.ForeColor = Color.FromArgb(0, 192, 0);
            label5.Location = new Point(453, 80);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(58, 91);
            label5.TabIndex = 9;
            label5.Text = "l";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft JhengHei UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label6.ForeColor = Color.Red;
            label6.Location = new Point(497, 80);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(80, 91);
            label6.TabIndex = 10;
            label6.Text = "e";
            // 
            // menuStrip1
            // 
            menuStrip1.Anchor = AnchorStyles.Left;
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.Font = new Font("Microsoft JhengHei", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { 圖片ToolStripMenuItem, 地圖ToolStripMenuItem, 新聞ToolStripMenuItem, 翻譯ToolStripMenuItem, gmailToolStripMenuItem, 更多ToolStripMenuItem, 紀錄ToolStripMenuItem, 登入ToolStripMenuItem, geminiToolStripMenuItem });
            menuStrip1.Location = new Point(-1, 30);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(703, 31);
            menuStrip1.TabIndex = 11;
            menuStrip1.Text = "menuStrip1";
            // 
            // 圖片ToolStripMenuItem
            // 
            圖片ToolStripMenuItem.Name = "圖片ToolStripMenuItem";
            圖片ToolStripMenuItem.Size = new Size(62, 27);
            圖片ToolStripMenuItem.Text = "圖片";
            圖片ToolStripMenuItem.Click += 圖片ToolStripMenuItem_Click;
            // 
            // 地圖ToolStripMenuItem
            // 
            地圖ToolStripMenuItem.Name = "地圖ToolStripMenuItem";
            地圖ToolStripMenuItem.Size = new Size(62, 27);
            地圖ToolStripMenuItem.Text = "地圖";
            // 
            // 新聞ToolStripMenuItem
            // 
            新聞ToolStripMenuItem.Name = "新聞ToolStripMenuItem";
            新聞ToolStripMenuItem.Size = new Size(62, 27);
            新聞ToolStripMenuItem.Text = "新聞";
            // 
            // 翻譯ToolStripMenuItem
            // 
            翻譯ToolStripMenuItem.Name = "翻譯ToolStripMenuItem";
            翻譯ToolStripMenuItem.Size = new Size(62, 27);
            翻譯ToolStripMenuItem.Text = "翻譯";
            // 
            // gmailToolStripMenuItem
            // 
            gmailToolStripMenuItem.Name = "gmailToolStripMenuItem";
            gmailToolStripMenuItem.Size = new Size(76, 27);
            gmailToolStripMenuItem.Text = "Gmail";
            gmailToolStripMenuItem.Click += gmailToolStripMenuItem_Click;
            // 
            // 更多ToolStripMenuItem
            // 
            更多ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 硬碟ToolStripMenuItem, youtubeToolStripMenuItem });
            更多ToolStripMenuItem.Name = "更多ToolStripMenuItem";
            更多ToolStripMenuItem.Size = new Size(62, 27);
            更多ToolStripMenuItem.Text = "更多";
            // 
            // 硬碟ToolStripMenuItem
            // 
            硬碟ToolStripMenuItem.Name = "硬碟ToolStripMenuItem";
            硬碟ToolStripMenuItem.Size = new Size(180, 34);
            硬碟ToolStripMenuItem.Text = "硬碟";
            // 
            // youtubeToolStripMenuItem
            // 
            youtubeToolStripMenuItem.Name = "youtubeToolStripMenuItem";
            youtubeToolStripMenuItem.Size = new Size(180, 34);
            youtubeToolStripMenuItem.Text = "youtube";
            youtubeToolStripMenuItem.Click += youtubeToolStripMenuItem_Click;
            // 
            // 紀錄ToolStripMenuItem
            // 
            紀錄ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 搜尋紀錄ToolStripMenuItem, 紀錄HToolStripMenuItem });
            紀錄ToolStripMenuItem.Name = "紀錄ToolStripMenuItem";
            紀錄ToolStripMenuItem.Size = new Size(88, 27);
            紀錄ToolStripMenuItem.Text = "紀錄(&H)";
            紀錄ToolStripMenuItem.Click += 紀錄ToolStripMenuItem_Click;
            // 
            // 搜尋紀錄ToolStripMenuItem
            // 
            搜尋紀錄ToolStripMenuItem.Name = "搜尋紀錄ToolStripMenuItem";
            搜尋紀錄ToolStripMenuItem.Size = new Size(182, 34);
            搜尋紀錄ToolStripMenuItem.Text = "搜尋紀錄";
            // 
            // 紀錄HToolStripMenuItem
            // 
            紀錄HToolStripMenuItem.Name = "紀錄HToolStripMenuItem";
            紀錄HToolStripMenuItem.Size = new Size(182, 34);
            紀錄HToolStripMenuItem.Text = "紀錄(&H)";
            // 
            // 登入ToolStripMenuItem
            // 
            登入ToolStripMenuItem.Name = "登入ToolStripMenuItem";
            登入ToolStripMenuItem.Size = new Size(62, 27);
            登入ToolStripMenuItem.Text = "登入";
            登入ToolStripMenuItem.Click += 登入ToolStripMenuItem_Click;
            // 
            // geminiToolStripMenuItem
            // 
            geminiToolStripMenuItem.Name = "geminiToolStripMenuItem";
            geminiToolStripMenuItem.Size = new Size(159, 27);
            geminiToolStripMenuItem.Text = "Gemini(胡微基))";
            geminiToolStripMenuItem.Click += geminiToolStripMenuItem_Click;
            // 
            // URL
            // 
            URL.Location = new Point(163, 70);
            URL.Multiline = true;
            URL.Name = "URL";
            URL.Size = new Size(1015, 39);
            URL.TabIndex = 12;
            URL.Text = "www.盜版google.com";
            URL.TextChanged += URL_TextChanged;
            URL.KeyDown += URL_KeyDown;
            // 
            // button1
            // 
            button1.Location = new Point(82, 70);
            button1.Name = "button1";
            button1.Size = new Size(33, 34);
            button1.TabIndex = 13;
            button1.Text = "→";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(43, 70);
            button2.Name = "button2";
            button2.Size = new Size(33, 34);
            button2.TabIndex = 14;
            button2.Text = "←";
            button2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(label7);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(add);
            panel1.Location = new Point(0, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1120, 60);
            panel1.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label7.Location = new Point(43, 17);
            label7.Margin = new Padding(5, 0, 5, 0);
            label7.Name = "label7";
            label7.Size = new Size(85, 30);
            label7.TabIndex = 15;
            label7.Text = "新分頁";
            // 
            // button4
            // 
            button4.Location = new Point(203, 20);
            button4.Name = "button4";
            button4.Size = new Size(24, 29);
            button4.TabIndex = 18;
            button4.Text = "❌";
            button4.UseVisualStyleBackColor = true;
            // 
            // add
            // 
            add.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            add.Location = new Point(259, 8);
            add.Name = "add";
            add.Size = new Size(55, 48);
            add.TabIndex = 17;
            add.Text = "➕";
            add.UseVisualStyleBackColor = true;
            add.Click += add_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(menuStrip1);
            panel2.Controls.Add(txtSearch);
            panel2.Controls.Add(btnSearch);
            panel2.Controls.Add(lstResults);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(G);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label3);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 110);
            panel2.Name = "panel2";
            panel2.Size = new Size(1301, 580);
            panel2.TabIndex = 16;
            panel2.Visible = false;
            // 
            // webViewChrome
            // 
            webViewChrome.AllowExternalDrop = true;
            webViewChrome.CreationProperties = null;
            webViewChrome.DefaultBackgroundColor = Color.White;
            webViewChrome.Dock = DockStyle.Bottom;
            webViewChrome.Location = new Point(0, -470);
            webViewChrome.Name = "webViewChrome";
            webViewChrome.Size = new Size(1301, 580);
            webViewChrome.TabIndex = 12;
            webViewChrome.ZoomFactor = 1D;
            webViewChrome.Click += webViewChrome_Click;
            webViewChrome.Resize += webViewChrome_Resize;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1301, 690);
            Controls.Add(webViewChrome);
            Controls.Add(URL);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Margin = new Padding(5);
            Name = "Form1";
            Text = "盜版Google Chrome";
            MaximumSizeChanged += Form1_MaximumSizeChanged;
            Resize += Form1_Resize_1;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)webViewChrome).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button txtSearch;
        private TextBox btnSearch;
        private ListBox lstResults;
        private Label label1;
        private Label G;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem 圖片ToolStripMenuItem;
        private ToolStripMenuItem 地圖ToolStripMenuItem;
        private ToolStripMenuItem 新聞ToolStripMenuItem;
        private ToolStripMenuItem 翻譯ToolStripMenuItem;
        private ToolStripMenuItem gmailToolStripMenuItem;
        private ToolStripMenuItem 更多ToolStripMenuItem;
        private ToolStripMenuItem 硬碟ToolStripMenuItem;
        private ToolStripMenuItem 紀錄ToolStripMenuItem;
        private ToolStripMenuItem 搜尋紀錄ToolStripMenuItem;
        private ToolStripMenuItem 登入ToolStripMenuItem;
        private ToolStripMenuItem geminiToolStripMenuItem;
        private ToolStripMenuItem youtubeToolStripMenuItem;
        private TextBox URL;
        private Button button1;
        private Button button2;
        private ToolStripMenuItem 紀錄HToolStripMenuItem;
        private Panel panel1;
        private Panel panel2;
        private Button button4;
        private Button add;
        private Label label7;
        private Microsoft.Web.WebView2.WinForms.WebView2 webViewChrome;
    }
}
