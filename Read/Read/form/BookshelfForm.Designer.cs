namespace Read.form
{
    partial class BookshelfForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookshelfForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.手动选择ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.遍历文件夹ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.移除失效书籍ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.markerRightMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.开始阅读ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.移除所选文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.复制文件路径ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.全部选中ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.取消全选ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookDgv = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chapter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.percentStr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Percent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaxPageNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nowPageNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Url = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartUrl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            this.markerRightMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // minLabel
            // 
            this.minLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(63)))), ((int)(((byte)(80)))));
            this.minLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(181)))), ((int)(((byte)(182)))));
            this.minLabel.Location = new System.Drawing.Point(694, 5);
            // 
            // closeLabel
            // 
            this.closeLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(63)))), ((int)(((byte)(80)))));
            this.closeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(181)))), ((int)(((byte)(182)))));
            this.closeLabel.Location = new System.Drawing.Point(718, 1);
            // 
            // messageBox
            // 
            this.messageBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(63)))), ((int)(((byte)(80)))));
            this.messageBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(99)))), ((int)(((byte)(71)))));
            this.messageBox.Location = new System.Drawing.Point(86, 9);
            this.messageBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.messageBox.TextChanged += new System.EventHandler(this.messageBox_TextChanged);
            // 
            // scapegoat
            // 
            this.scapegoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(63)))), ((int)(((byte)(80)))));
            this.scapegoat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(181)))), ((int)(((byte)(182)))));
            this.scapegoat.Location = new System.Drawing.Point(12, 682);
            this.scapegoat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            // 
            // separationLine
            // 
            this.separationLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(181)))), ((int)(((byte)(182)))));
            this.separationLine.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(181)))), ((int)(((byte)(182)))));
            this.separationLine.Size = new System.Drawing.Size(726, 1);
            // 
            // titleBox
            // 
            this.titleBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(63)))), ((int)(((byte)(80)))));
            this.titleBox.ForeColor = System.Drawing.Color.Tomato;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.手动选择ToolStripMenuItem,
            this.遍历文件夹ToolStripMenuItem,
            this.移除失效书籍ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(375, 4);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(340, 25);
            this.menuStrip1.TabIndex = 74;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 手动选择ToolStripMenuItem
            // 
            this.手动选择ToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.手动选择ToolStripMenuItem.Name = "手动选择ToolStripMenuItem";
            this.手动选择ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.手动选择ToolStripMenuItem.Text = "导入书籍";
            this.手动选择ToolStripMenuItem.Click += new System.EventHandler(this.手动选择ToolStripMenuItem_Click);
            // 
            // 遍历文件夹ToolStripMenuItem
            // 
            this.遍历文件夹ToolStripMenuItem.Name = "遍历文件夹ToolStripMenuItem";
            this.遍历文件夹ToolStripMenuItem.Size = new System.Drawing.Size(80, 21);
            this.遍历文件夹ToolStripMenuItem.Text = "遍历文件夹";
            this.遍历文件夹ToolStripMenuItem.Click += new System.EventHandler(this.扫描文件夹ToolStripMenuItem_Click);
            // 
            // 移除失效书籍ToolStripMenuItem
            // 
            this.移除失效书籍ToolStripMenuItem.Name = "移除失效书籍ToolStripMenuItem";
            this.移除失效书籍ToolStripMenuItem.Size = new System.Drawing.Size(92, 21);
            this.移除失效书籍ToolStripMenuItem.Text = "清除失效书籍";
            this.移除失效书籍ToolStripMenuItem.Click += new System.EventHandler(this.移除失效书籍ToolStripMenuItem_Click);
            // 
            // markerRightMenu
            // 
            this.markerRightMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.开始阅读ToolStripMenuItem,
            this.移除所选文件ToolStripMenuItem,
            this.复制文件路径ToolStripMenuItem,
            this.全部选中ToolStripMenuItem,
            this.取消全选ToolStripMenuItem});
            this.markerRightMenu.Name = "markerRightMenu";
            this.markerRightMenu.Size = new System.Drawing.Size(125, 114);
            // 
            // 开始阅读ToolStripMenuItem
            // 
            this.开始阅读ToolStripMenuItem.Name = "开始阅读ToolStripMenuItem";
            this.开始阅读ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.开始阅读ToolStripMenuItem.Text = "开始阅读";
            this.开始阅读ToolStripMenuItem.Click += new System.EventHandler(this.开始阅读ToolStripMenuItem_Click);
            // 
            // 移除所选文件ToolStripMenuItem
            // 
            this.移除所选文件ToolStripMenuItem.Name = "移除所选文件ToolStripMenuItem";
            this.移除所选文件ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.移除所选文件ToolStripMenuItem.Text = "移出书架";
            this.移除所选文件ToolStripMenuItem.Click += new System.EventHandler(this.移除所选文件ToolStripMenuItem_Click);
            // 
            // 复制文件路径ToolStripMenuItem
            // 
            this.复制文件路径ToolStripMenuItem.Name = "复制文件路径ToolStripMenuItem";
            this.复制文件路径ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.复制文件路径ToolStripMenuItem.Text = "复制路径";
            this.复制文件路径ToolStripMenuItem.Click += new System.EventHandler(this.复制文件路径ToolStripMenuItem_Click);
            // 
            // 全部选中ToolStripMenuItem
            // 
            this.全部选中ToolStripMenuItem.Name = "全部选中ToolStripMenuItem";
            this.全部选中ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.全部选中ToolStripMenuItem.Text = "全部选中";
            this.全部选中ToolStripMenuItem.Click += new System.EventHandler(this.全部选中ToolStripMenuItem_Click);
            // 
            // 取消全选ToolStripMenuItem
            // 
            this.取消全选ToolStripMenuItem.Name = "取消全选ToolStripMenuItem";
            this.取消全选ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.取消全选ToolStripMenuItem.Text = "取消全选";
            this.取消全选ToolStripMenuItem.Click += new System.EventHandler(this.取消全选ToolStripMenuItem_Click);
            // 
            // bookDgv
            // 
            this.bookDgv.AllowUserToAddRows = false;
            this.bookDgv.AllowUserToDeleteRows = false;
            this.bookDgv.AllowUserToResizeColumns = false;
            this.bookDgv.AllowUserToResizeRows = false;
            this.bookDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bookDgv.BackgroundColor = System.Drawing.SystemColors.Control;
            this.bookDgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bookDgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.bookDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bookDgv.ColumnHeadersVisible = false;
            this.bookDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.bSize,
            this.chapter,
            this.percentStr,
            this.time,
            this.Percent,
            this.MaxPageNum,
            this.nowPageNum,
            this.Url,
            this.PartUrl});
            this.bookDgv.ContextMenuStrip = this.markerRightMenu;
            this.bookDgv.Location = new System.Drawing.Point(10, 39);
            this.bookDgv.Name = "bookDgv";
            this.bookDgv.ReadOnly = true;
            this.bookDgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bookDgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.bookDgv.RowTemplate.Height = 23;
            this.bookDgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bookDgv.Size = new System.Drawing.Size(728, 439);
            this.bookDgv.TabIndex = 94;
            this.bookDgv.SelectionChanged += new System.EventHandler(this.bookDgv_SelectionChanged);
            this.bookDgv.DoubleClick += new System.EventHandler(this.bookDgv_DoubleClick);
            // 
            // name
            // 
            this.name.DataPropertyName = "Name";
            this.name.FillWeight = 25F;
            this.name.HeaderText = "书名";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // bSize
            // 
            this.bSize.DataPropertyName = "Size";
            this.bSize.FillWeight = 12F;
            this.bSize.HeaderText = "书籍大小";
            this.bSize.Name = "bSize";
            this.bSize.ReadOnly = true;
            // 
            // chapter
            // 
            this.chapter.DataPropertyName = "Chapter";
            this.chapter.FillWeight = 40F;
            this.chapter.HeaderText = "章节或预览";
            this.chapter.Name = "chapter";
            this.chapter.ReadOnly = true;
            // 
            // percentStr
            // 
            this.percentStr.DataPropertyName = "PercentStr";
            this.percentStr.FillWeight = 8F;
            this.percentStr.HeaderText = "阅读进度(显示)";
            this.percentStr.Name = "percentStr";
            this.percentStr.ReadOnly = true;
            // 
            // time
            // 
            this.time.DataPropertyName = "LastReadTime";
            this.time.FillWeight = 16F;
            this.time.HeaderText = "时间";
            this.time.Name = "time";
            this.time.ReadOnly = true;
            // 
            // Percent
            // 
            this.Percent.DataPropertyName = "ReadPercent";
            this.Percent.FillWeight = 1F;
            this.Percent.HeaderText = "进度";
            this.Percent.Name = "Percent";
            this.Percent.ReadOnly = true;
            this.Percent.Visible = false;
            // 
            // MaxPageNum
            // 
            this.MaxPageNum.DataPropertyName = "MaxPageNum";
            this.MaxPageNum.FillWeight = 1F;
            this.MaxPageNum.HeaderText = "最大页数";
            this.MaxPageNum.Name = "MaxPageNum";
            this.MaxPageNum.ReadOnly = true;
            this.MaxPageNum.Visible = false;
            // 
            // nowPageNum
            // 
            this.nowPageNum.DataPropertyName = "NowPageNum";
            this.nowPageNum.FillWeight = 1F;
            this.nowPageNum.HeaderText = "当前页码";
            this.nowPageNum.Name = "nowPageNum";
            this.nowPageNum.ReadOnly = true;
            this.nowPageNum.Visible = false;
            // 
            // Url
            // 
            this.Url.DataPropertyName = "Url";
            this.Url.FillWeight = 1F;
            this.Url.HeaderText = "文件路径";
            this.Url.Name = "Url";
            this.Url.ReadOnly = true;
            this.Url.Visible = false;
            // 
            // PartUrl
            // 
            this.PartUrl.DataPropertyName = "PartUrl";
            this.PartUrl.FillWeight = 1F;
            this.PartUrl.HeaderText = "局部路径";
            this.PartUrl.Name = "PartUrl";
            this.PartUrl.ReadOnly = true;
            // 
            // BookshelfForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 490);
            this.Controls.Add(this.bookDgv);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(181)))), ((int)(((byte)(182)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.Name = "BookshelfForm";
            this.Text = "书架";
            this.Load += new System.EventHandler(this.OpenBook_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.BookshelfForm_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.BookshelfForm_DragEnter);
            this.Controls.SetChildIndex(this.titleBox, 0);
            this.Controls.SetChildIndex(this.menuStrip1, 0);
            this.Controls.SetChildIndex(this.bookDgv, 0);
            this.Controls.SetChildIndex(this.separationLine, 0);
            this.Controls.SetChildIndex(this.messageBox, 0);
            this.Controls.SetChildIndex(this.scapegoat, 0);
            this.Controls.SetChildIndex(this.closeLabel, 0);
            this.Controls.SetChildIndex(this.minLabel, 0);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.markerRightMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bookDgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.ToolStripMenuItem 手动选择ToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem 移除失效书籍ToolStripMenuItem;
        public System.Windows.Forms.ContextMenuStrip markerRightMenu;
        public System.Windows.Forms.ToolStripMenuItem 移除所选文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 复制文件路径ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 全部选中ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 取消全选ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 开始阅读ToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem 遍历文件夹ToolStripMenuItem;
        public System.Windows.Forms.DataGridView bookDgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn bSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn chapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn percentStr;
        private System.Windows.Forms.DataGridViewTextBoxColumn time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Percent;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaxPageNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn nowPageNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Url;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartUrl;
    }
}