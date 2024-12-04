using Read.model;
using Reader.model;
using System.Windows.Forms;
namespace Read.form
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)//取消方向键对控件的焦点的控件，用自己自定义的函数处理各个方向键的处理函数
        {
            string code = keyData.ToString();
            //屏蔽tab键
            if (code.Equals("Tab"))
            {
                return true;
            }

            if (code.Equals(HotKey.getKeyCode(0)))
            {
                previousPage();
                return true;
            }
            else if (code.Equals(HotKey.getKeyCode(1)))
            {
                nextPage();
                return true;
            }
            else if (code.Equals(HotKey.getKeyCode(2)))
            {
                previousPage();
                return true;
            }
            else if (code.Equals(HotKey.getKeyCode(3)))
            {
                nextPage();
                return true;
            }
            else if (code.Equals(HotKey.getKeyCode(4)))
            {
                WindowState = FormWindowState.Minimized;
                this.ShowInTaskbar = false;
                return true;
            }
            else if (code.Equals(HotKey.getKeyCode(5)))
            {
                saveLastRead();
                System.Environment.Exit(0);
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.hotkeys = new System.Windows.Forms.PictureBox();
            this.markers = new System.Windows.Forms.PictureBox();
            this.catalogs = new System.Windows.Forms.PictureBox();
            this.sreach = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.myBooks = new System.Windows.Forms.PictureBox();
            this.addmarker = new System.Windows.Forms.PictureBox();
            this.setting = new System.Windows.Forms.PictureBox();
            this.ReadBar = new Orange.service.MyProgressBar();
            this.bookNameText = new System.Windows.Forms.TextBox();
            this.percentage = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.maxCount = new System.Windows.Forms.TextBox();
            this.CatalogText = new System.Windows.Forms.TextBox();
            this.nowCount = new System.Windows.Forms.TextBox();
            this.bookText = new System.Windows.Forms.RichTextBox();
            this.operateText = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.添加书签ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.qiyongMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.fuzhiMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.sousuoMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.jiansuoMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.refresh = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.hotkeys)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.markers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.catalogs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sreach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myBooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addmarker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.setting)).BeginInit();
            this.operateText.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.refresh)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // minLabel
            // 
            this.minLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(63)))), ((int)(((byte)(80)))));
            this.minLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(181)))), ((int)(((byte)(182)))));
            this.minLabel.Location = new System.Drawing.Point(896, 5);
            // 
            // closeLabel
            // 
            this.closeLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(63)))), ((int)(((byte)(80)))));
            this.closeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(181)))), ((int)(((byte)(182)))));
            this.closeLabel.Location = new System.Drawing.Point(921, 1);
            // 
            // messageBox
            // 
            this.messageBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(63)))), ((int)(((byte)(80)))));
            this.messageBox.Font = new System.Drawing.Font("微软雅黑", 10.5F);
            this.messageBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(181)))), ((int)(((byte)(182)))));
            this.messageBox.Location = new System.Drawing.Point(313, 5);
            this.messageBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.messageBox.Size = new System.Drawing.Size(301, 19);
            // 
            // scapegoat
            // 
            this.scapegoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(63)))), ((int)(((byte)(80)))));
            this.scapegoat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(181)))), ((int)(((byte)(182)))));
            // 
            // separationLine
            // 
            this.separationLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(181)))), ((int)(((byte)(182)))));
            this.separationLine.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(181)))), ((int)(((byte)(182)))));
            this.separationLine.Size = new System.Drawing.Size(727, 1);
            this.separationLine.Visible = false;
            // 
            // titleBox
            // 
            this.titleBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(63)))), ((int)(((byte)(80)))));
            this.titleBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(181)))), ((int)(((byte)(182)))));
            this.titleBox.Location = new System.Drawing.Point(954, 8);
            // 
            // hotkeys
            // 
            this.hotkeys.BackColor = System.Drawing.Color.Transparent;
            this.hotkeys.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hotkeys.Image = ((System.Drawing.Image)(resources.GetObject("hotkeys.Image")));
            this.hotkeys.Location = new System.Drawing.Point(0, 216);
            this.hotkeys.Name = "hotkeys";
            this.hotkeys.Size = new System.Drawing.Size(54, 47);
            this.hotkeys.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.hotkeys.TabIndex = 57;
            this.hotkeys.TabStop = false;
            this.hotkeys.Tag = "快捷键设置";
            this.hotkeys.Click += new System.EventHandler(this.hotkeys_Click);
            this.hotkeys.MouseEnter += new System.EventHandler(this.addmarker_MouseEnter);
            this.hotkeys.MouseLeave += new System.EventHandler(this.addmarker_MouseLeave);
            this.hotkeys.MouseHover += new System.EventHandler(this.myBooks_MouseHover);
            // 
            // markers
            // 
            this.markers.BackColor = System.Drawing.Color.Transparent;
            this.markers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.markers.Image = ((System.Drawing.Image)(resources.GetObject("markers.Image")));
            this.markers.Location = new System.Drawing.Point(0, 110);
            this.markers.Name = "markers";
            this.markers.Size = new System.Drawing.Size(54, 47);
            this.markers.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.markers.TabIndex = 56;
            this.markers.TabStop = false;
            this.markers.Tag = "书签管理";
            this.markers.Click += new System.EventHandler(this.markers_Click);
            this.markers.MouseEnter += new System.EventHandler(this.addmarker_MouseEnter);
            this.markers.MouseLeave += new System.EventHandler(this.addmarker_MouseLeave);
            this.markers.MouseHover += new System.EventHandler(this.myBooks_MouseHover);
            // 
            // catalogs
            // 
            this.catalogs.BackColor = System.Drawing.Color.Transparent;
            this.catalogs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.catalogs.Image = ((System.Drawing.Image)(resources.GetObject("catalogs.Image")));
            this.catalogs.Location = new System.Drawing.Point(0, 57);
            this.catalogs.Name = "catalogs";
            this.catalogs.Size = new System.Drawing.Size(54, 47);
            this.catalogs.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.catalogs.TabIndex = 55;
            this.catalogs.TabStop = false;
            this.catalogs.Tag = "章节目录";
            this.catalogs.Click += new System.EventHandler(this.catalogs_Click);
            this.catalogs.MouseEnter += new System.EventHandler(this.addmarker_MouseEnter);
            this.catalogs.MouseLeave += new System.EventHandler(this.addmarker_MouseLeave);
            this.catalogs.MouseHover += new System.EventHandler(this.myBooks_MouseHover);
            // 
            // sreach
            // 
            this.sreach.BackColor = System.Drawing.Color.Transparent;
            this.sreach.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sreach.ErrorImage = ((System.Drawing.Image)(resources.GetObject("sreach.ErrorImage")));
            this.sreach.Image = ((System.Drawing.Image)(resources.GetObject("sreach.Image")));
            this.sreach.Location = new System.Drawing.Point(0, 163);
            this.sreach.Name = "sreach";
            this.sreach.Size = new System.Drawing.Size(54, 47);
            this.sreach.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.sreach.TabIndex = 53;
            this.sreach.TabStop = false;
            this.sreach.Tag = "全文检索";
            this.sreach.Click += new System.EventHandler(this.sreach_Click);
            this.sreach.MouseEnter += new System.EventHandler(this.addmarker_MouseEnter);
            this.sreach.MouseLeave += new System.EventHandler(this.addmarker_MouseLeave);
            this.sreach.MouseHover += new System.EventHandler(this.myBooks_MouseHover);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(55, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 623);
            this.panel1.TabIndex = 58;
            // 
            // myBooks
            // 
            this.myBooks.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.myBooks.BackColor = System.Drawing.Color.Transparent;
            this.myBooks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.myBooks.ErrorImage = null;
            this.myBooks.Image = ((System.Drawing.Image)(resources.GetObject("myBooks.Image")));
            this.myBooks.Location = new System.Drawing.Point(0, 4);
            this.myBooks.Name = "myBooks";
            this.myBooks.Size = new System.Drawing.Size(54, 47);
            this.myBooks.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.myBooks.TabIndex = 54;
            this.myBooks.TabStop = false;
            this.myBooks.Tag = "书架";
            this.myBooks.Click += new System.EventHandler(this.myBooks_Click);
            this.myBooks.MouseEnter += new System.EventHandler(this.addmarker_MouseEnter);
            this.myBooks.MouseLeave += new System.EventHandler(this.addmarker_MouseLeave);
            this.myBooks.MouseHover += new System.EventHandler(this.myBooks_MouseHover);
            // 
            // addmarker
            // 
            this.addmarker.BackColor = System.Drawing.Color.Transparent;
            this.addmarker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addmarker.Image = ((System.Drawing.Image)(resources.GetObject("addmarker.Image")));
            this.addmarker.Location = new System.Drawing.Point(0, 375);
            this.addmarker.Name = "addmarker";
            this.addmarker.Size = new System.Drawing.Size(54, 47);
            this.addmarker.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.addmarker.TabIndex = 52;
            this.addmarker.TabStop = false;
            this.addmarker.Tag = "添加书签";
            this.addmarker.Click += new System.EventHandler(this.addmarker_Click);
            this.addmarker.MouseEnter += new System.EventHandler(this.addmarker_MouseEnter);
            this.addmarker.MouseLeave += new System.EventHandler(this.addmarker_MouseLeave);
            this.addmarker.MouseHover += new System.EventHandler(this.myBooks_MouseHover);
            // 
            // setting
            // 
            this.setting.BackColor = System.Drawing.Color.Transparent;
            this.setting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.setting.Image = ((System.Drawing.Image)(resources.GetObject("setting.Image")));
            this.setting.Location = new System.Drawing.Point(0, 269);
            this.setting.Name = "setting";
            this.setting.Size = new System.Drawing.Size(54, 47);
            this.setting.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.setting.TabIndex = 51;
            this.setting.TabStop = false;
            this.setting.Tag = "阅读设置";
            this.setting.Click += new System.EventHandler(this.setting_Click);
            this.setting.MouseEnter += new System.EventHandler(this.addmarker_MouseEnter);
            this.setting.MouseLeave += new System.EventHandler(this.addmarker_MouseLeave);
            this.setting.MouseHover += new System.EventHandler(this.myBooks_MouseHover);
            // 
            // ReadBar
            // 
            this.ReadBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ReadBar.Location = new System.Drawing.Point(72, 598);
            this.ReadBar.Maximum = 10000;
            this.ReadBar.Name = "ReadBar";
            this.ReadBar.Size = new System.Drawing.Size(862, 6);
            this.ReadBar.TabIndex = 60;
            this.ReadBar.Click += new System.EventHandler(this.ReadBar_Click);
            this.ReadBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ReadBar_MouseUp);
            // 
            // bookNameText
            // 
            this.bookNameText.BackColor = System.Drawing.Color.White;
            this.bookNameText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bookNameText.Cursor = System.Windows.Forms.Cursors.Default;
            this.bookNameText.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.bookNameText.Location = new System.Drawing.Point(597, 605);
            this.bookNameText.Name = "bookNameText";
            this.bookNameText.ReadOnly = true;
            this.bookNameText.Size = new System.Drawing.Size(284, 17);
            this.bookNameText.TabIndex = 64;
            this.bookNameText.TabStop = false;
            this.bookNameText.Text = "尚未载入书籍";
            this.bookNameText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // percentage
            // 
            this.percentage.BackColor = System.Drawing.Color.White;
            this.percentage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.percentage.Cursor = System.Windows.Forms.Cursors.Default;
            this.percentage.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.percentage.Location = new System.Drawing.Point(887, 607);
            this.percentage.Name = "percentage";
            this.percentage.Size = new System.Drawing.Size(47, 16);
            this.percentage.TabIndex = 65;
            this.percentage.Text = "0%";
            this.percentage.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox1.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.textBox1.Location = new System.Drawing.Point(493, 608);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(10, 16);
            this.textBox1.TabIndex = 63;
            this.textBox1.TabStop = false;
            this.textBox1.Text = "/";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // maxCount
            // 
            this.maxCount.BackColor = System.Drawing.Color.White;
            this.maxCount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.maxCount.Cursor = System.Windows.Forms.Cursors.Default;
            this.maxCount.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.maxCount.Location = new System.Drawing.Point(507, 608);
            this.maxCount.Name = "maxCount";
            this.maxCount.ReadOnly = true;
            this.maxCount.Size = new System.Drawing.Size(41, 16);
            this.maxCount.TabIndex = 62;
            this.maxCount.TabStop = false;
            this.maxCount.Text = "0";
            // 
            // CatalogText
            // 
            this.CatalogText.BackColor = System.Drawing.Color.White;
            this.CatalogText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CatalogText.Cursor = System.Windows.Forms.Cursors.Default;
            this.CatalogText.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.CatalogText.Location = new System.Drawing.Point(77, 605);
            this.CatalogText.Name = "CatalogText";
            this.CatalogText.Size = new System.Drawing.Size(311, 17);
            this.CatalogText.TabIndex = 66;
            this.CatalogText.Text = "章节";
            // 
            // nowCount
            // 
            this.nowCount.BackColor = System.Drawing.Color.White;
            this.nowCount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nowCount.Cursor = System.Windows.Forms.Cursors.Default;
            this.nowCount.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.nowCount.Location = new System.Drawing.Point(448, 608);
            this.nowCount.Name = "nowCount";
            this.nowCount.ReadOnly = true;
            this.nowCount.Size = new System.Drawing.Size(41, 16);
            this.nowCount.TabIndex = 61;
            this.nowCount.TabStop = false;
            this.nowCount.Text = "0";
            this.nowCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nowCount.TextChanged += new System.EventHandler(this.nowCount_TextChanged);
            // 
            // bookText
            // 
            this.bookText.BackColor = System.Drawing.Color.White;
            this.bookText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bookText.ContextMenuStrip = this.operateText;
            this.bookText.Cursor = System.Windows.Forms.Cursors.Default;
            this.bookText.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bookText.Location = new System.Drawing.Point(77, 27);
            this.bookText.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.bookText.Name = "bookText";
            this.bookText.ReadOnly = true;
            this.bookText.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.bookText.Size = new System.Drawing.Size(858, 570);
            this.bookText.TabIndex = 59;
            this.bookText.TabStop = false;
            this.bookText.Text = "";
            this.bookText.WordWrap = false;
            this.bookText.TextChanged += new System.EventHandler(this.bookText_TextChanged);
            // 
            // operateText
            // 
            this.operateText.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.添加书签ToolStripMenuItem,
            this.qiyongMenu,
            this.fuzhiMenu,
            this.sousuoMenu,
            this.jiansuoMenu});
            this.operateText.Name = "contextMenuStrip1";
            this.operateText.Size = new System.Drawing.Size(125, 114);
            // 
            // 添加书签ToolStripMenuItem
            // 
            this.添加书签ToolStripMenuItem.Name = "添加书签ToolStripMenuItem";
            this.添加书签ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.添加书签ToolStripMenuItem.Text = "添加书签";
            this.添加书签ToolStripMenuItem.Click += new System.EventHandler(this.添加书签ToolStripMenuItem_Click);
            // 
            // qiyongMenu
            // 
            this.qiyongMenu.Name = "qiyongMenu";
            this.qiyongMenu.Size = new System.Drawing.Size(124, 22);
            this.qiyongMenu.Text = "选中文本";
            this.qiyongMenu.Click += new System.EventHandler(this.qiyongMenu_Click);
            // 
            // fuzhiMenu
            // 
            this.fuzhiMenu.Name = "fuzhiMenu";
            this.fuzhiMenu.Size = new System.Drawing.Size(124, 22);
            this.fuzhiMenu.Text = "复制";
            this.fuzhiMenu.Visible = false;
            this.fuzhiMenu.Click += new System.EventHandler(this.fuzhiMenu_Click);
            // 
            // sousuoMenu
            // 
            this.sousuoMenu.Name = "sousuoMenu";
            this.sousuoMenu.Size = new System.Drawing.Size(124, 22);
            this.sousuoMenu.Text = "搜索";
            this.sousuoMenu.Visible = false;
            this.sousuoMenu.Click += new System.EventHandler(this.sousuoMenu_Click);
            // 
            // jiansuoMenu
            // 
            this.jiansuoMenu.Name = "jiansuoMenu";
            this.jiansuoMenu.Size = new System.Drawing.Size(124, 22);
            this.jiansuoMenu.Text = "全文检索";
            this.jiansuoMenu.Visible = false;
            this.jiansuoMenu.Click += new System.EventHandler(this.jiansuoMenu_Click);
            // 
            // refresh
            // 
            this.refresh.BackColor = System.Drawing.Color.Transparent;
            this.refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refresh.Image = ((System.Drawing.Image)(resources.GetObject("refresh.Image")));
            this.refresh.Location = new System.Drawing.Point(0, 322);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(54, 47);
            this.refresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.refresh.TabIndex = 80;
            this.refresh.TabStop = false;
            this.refresh.Tag = "重新载入";
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            this.refresh.MouseEnter += new System.EventHandler(this.addmarker_MouseEnter);
            this.refresh.MouseLeave += new System.EventHandler(this.addmarker_MouseLeave);
            this.refresh.MouseHover += new System.EventHandler(this.myBooks_MouseHover);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.myBooks);
            this.panel2.Controls.Add(this.setting);
            this.panel2.Controls.Add(this.addmarker);
            this.panel2.Controls.Add(this.sreach);
            this.panel2.Controls.Add(this.catalogs);
            this.panel2.Controls.Add(this.markers);
            this.panel2.Controls.Add(this.hotkeys);
            this.panel2.Controls.Add(this.refresh);
            this.panel2.Location = new System.Drawing.Point(1, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(52, 587);
            this.panel2.TabIndex = 81;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 17);
            this.label1.TabIndex = 81;
            this.label1.Text = "▲";
            this.label1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.label1_MouseClick);
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(947, 630);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.bookNameText);
            this.Controls.Add(this.percentage);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.maxCount);
            this.Controls.Add(this.CatalogText);
            this.Controls.Add(this.nowCount);
            this.Controls.Add(this.ReadBar);
            this.Controls.Add(this.bookText);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(181)))), ((int)(((byte)(182)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "阅读";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainForm_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainForm_DragEnter);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.bookText, 0);
            this.Controls.SetChildIndex(this.ReadBar, 0);
            this.Controls.SetChildIndex(this.nowCount, 0);
            this.Controls.SetChildIndex(this.CatalogText, 0);
            this.Controls.SetChildIndex(this.maxCount, 0);
            this.Controls.SetChildIndex(this.textBox1, 0);
            this.Controls.SetChildIndex(this.percentage, 0);
            this.Controls.SetChildIndex(this.bookNameText, 0);
            this.Controls.SetChildIndex(this.titleBox, 0);
            this.Controls.SetChildIndex(this.separationLine, 0);
            this.Controls.SetChildIndex(this.scapegoat, 0);
            this.Controls.SetChildIndex(this.closeLabel, 0);
            this.Controls.SetChildIndex(this.minLabel, 0);
            this.Controls.SetChildIndex(this.messageBox, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.hotkeys)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.markers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.catalogs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sreach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myBooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addmarker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.setting)).EndInit();
            this.operateText.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.refresh)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox hotkeys;
        private System.Windows.Forms.PictureBox markers;
        private System.Windows.Forms.PictureBox catalogs;
        private System.Windows.Forms.PictureBox sreach;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox myBooks;
        private System.Windows.Forms.PictureBox addmarker;
        private System.Windows.Forms.PictureBox setting;
        private Orange.service.MyProgressBar ReadBar;
        private System.Windows.Forms.TextBox bookNameText;
        private System.Windows.Forms.TextBox percentage;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox maxCount;
        private System.Windows.Forms.TextBox CatalogText;
        private System.Windows.Forms.TextBox nowCount;
        public RichTextBox bookText;
        private ContextMenuStrip operateText;
        private ToolStripMenuItem qiyongMenu;
        private ToolStripMenuItem fuzhiMenu;
        private ToolStripMenuItem sousuoMenu;
        private ToolStripMenuItem jiansuoMenu;
        private PictureBox refresh;
        private ToolStripMenuItem 添加书签ToolStripMenuItem;
        private Panel panel2;
        private Label label1;
    }
}