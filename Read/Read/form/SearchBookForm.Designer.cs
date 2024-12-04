namespace Read.form
{
    partial class SearchBookForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchBookForm));
            this.searchResultDgv = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.导入书架ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.在文件夹中打开ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.导入所有ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.导入书籍ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartUrl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chapter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.percentStr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Percent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaxPageNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nowPageNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Url = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.searchResultDgv)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // minLabel
            // 
            this.minLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(63)))), ((int)(((byte)(80)))));
            this.minLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(181)))), ((int)(((byte)(182)))));
            this.minLabel.Location = new System.Drawing.Point(550, 6);
            // 
            // closeLabel
            // 
            this.closeLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(63)))), ((int)(((byte)(80)))));
            this.closeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(181)))), ((int)(((byte)(182)))));
            this.closeLabel.Location = new System.Drawing.Point(572, 1);
            // 
            // messageBox
            // 
            this.messageBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(63)))), ((int)(((byte)(80)))));
            this.messageBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(99)))), ((int)(((byte)(71)))));
            this.messageBox.Location = new System.Drawing.Point(71, 8);
            this.messageBox.Size = new System.Drawing.Size(229, 18);
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
            this.separationLine.Size = new System.Drawing.Size(580, 1);
            // 
            // titleBox
            // 
            this.titleBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(63)))), ((int)(((byte)(80)))));
            this.titleBox.ForeColor = System.Drawing.Color.Tomato;
            // 
            // searchResultDgv
            // 
            this.searchResultDgv.AllowUserToAddRows = false;
            this.searchResultDgv.AllowUserToDeleteRows = false;
            this.searchResultDgv.AllowUserToResizeColumns = false;
            this.searchResultDgv.AllowUserToResizeRows = false;
            this.searchResultDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.searchResultDgv.BackgroundColor = System.Drawing.SystemColors.Control;
            this.searchResultDgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.searchResultDgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.searchResultDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchResultDgv.ColumnHeadersVisible = false;
            this.searchResultDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.bSize,
            this.PartUrl,
            this.chapter,
            this.percentStr,
            this.time,
            this.Percent,
            this.MaxPageNum,
            this.nowPageNum,
            this.Url});
            this.searchResultDgv.ContextMenuStrip = this.contextMenuStrip1;
            this.searchResultDgv.Location = new System.Drawing.Point(10, 39);
            this.searchResultDgv.Name = "searchResultDgv";
            this.searchResultDgv.ReadOnly = true;
            this.searchResultDgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.searchResultDgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.searchResultDgv.RowTemplate.Height = 23;
            this.searchResultDgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.searchResultDgv.Size = new System.Drawing.Size(578, 341);
            this.searchResultDgv.TabIndex = 95;
            this.searchResultDgv.SelectionChanged += new System.EventHandler(this.searchResultDgv_SelectionChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.导入书架ToolStripMenuItem,
            this.在文件夹中打开ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(161, 48);
            // 
            // 导入书架ToolStripMenuItem
            // 
            this.导入书架ToolStripMenuItem.Name = "导入书架ToolStripMenuItem";
            this.导入书架ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.导入书架ToolStripMenuItem.Text = "导入书架";
            this.导入书架ToolStripMenuItem.Click += new System.EventHandler(this.导入书架ToolStripMenuItem_Click);
            // 
            // 在文件夹中打开ToolStripMenuItem
            // 
            this.在文件夹中打开ToolStripMenuItem.Name = "在文件夹中打开ToolStripMenuItem";
            this.在文件夹中打开ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.在文件夹中打开ToolStripMenuItem.Text = "在文件夹中打开";
            this.在文件夹中打开ToolStripMenuItem.Click += new System.EventHandler(this.在文件夹中打开ToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.导入所有ToolStripMenuItem,
            this.导入书籍ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(321, 6);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(144, 25);
            this.menuStrip1.TabIndex = 96;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 导入所有ToolStripMenuItem
            // 
            this.导入所有ToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.导入所有ToolStripMenuItem.Name = "导入所有ToolStripMenuItem";
            this.导入所有ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.导入所有ToolStripMenuItem.Text = "导入所有";
            this.导入所有ToolStripMenuItem.Click += new System.EventHandler(this.导入所有ToolStripMenuItem_Click);
            // 
            // 导入书籍ToolStripMenuItem
            // 
            this.导入书籍ToolStripMenuItem.Name = "导入书籍ToolStripMenuItem";
            this.导入书籍ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.导入书籍ToolStripMenuItem.Text = "导入书籍";
            this.导入书籍ToolStripMenuItem.Click += new System.EventHandler(this.导入书籍ToolStripMenuItem_Click);
            // 
            // name
            // 
            this.name.DataPropertyName = "Name";
            this.name.HeaderText = "书名";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // bSize
            // 
            this.bSize.DataPropertyName = "Size";
            this.bSize.FillWeight = 35F;
            this.bSize.HeaderText = "书籍大小";
            this.bSize.Name = "bSize";
            this.bSize.ReadOnly = true;
            // 
            // PartUrl
            // 
            this.PartUrl.DataPropertyName = "PartUrl";
            this.PartUrl.FillWeight = 85F;
            this.PartUrl.HeaderText = "局部路径";
            this.PartUrl.Name = "PartUrl";
            this.PartUrl.ReadOnly = true;
            // 
            // chapter
            // 
            this.chapter.DataPropertyName = "Chapter";
            this.chapter.FillWeight = 1F;
            this.chapter.HeaderText = "章节或预览";
            this.chapter.Name = "chapter";
            this.chapter.ReadOnly = true;
            this.chapter.Visible = false;
            // 
            // percentStr
            // 
            this.percentStr.DataPropertyName = "PercentStr";
            this.percentStr.FillWeight = 1F;
            this.percentStr.HeaderText = "阅读进度(显示)";
            this.percentStr.Name = "percentStr";
            this.percentStr.ReadOnly = true;
            this.percentStr.Visible = false;
            // 
            // time
            // 
            this.time.DataPropertyName = "LastReadTime";
            this.time.FillWeight = 1F;
            this.time.HeaderText = "时间";
            this.time.Name = "time";
            this.time.ReadOnly = true;
            this.time.Visible = false;
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
            // SearchBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 392);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.searchResultDgv);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(181)))), ((int)(((byte)(182)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SearchBookForm";
            this.Text = "导入书籍";
            this.Load += new System.EventHandler(this.Main_Load);
            this.Controls.SetChildIndex(this.titleBox, 0);
            this.Controls.SetChildIndex(this.searchResultDgv, 0);
            this.Controls.SetChildIndex(this.closeLabel, 0);
            this.Controls.SetChildIndex(this.minLabel, 0);
            this.Controls.SetChildIndex(this.messageBox, 0);
            this.Controls.SetChildIndex(this.separationLine, 0);
            this.Controls.SetChildIndex(this.scapegoat, 0);
            this.Controls.SetChildIndex(this.menuStrip1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.searchResultDgv)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView searchResultDgv;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 导入书架ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 在文件夹中打开ToolStripMenuItem;
        public System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.ToolStripMenuItem 导入所有ToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem 导入书籍ToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn bSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartUrl;
        private System.Windows.Forms.DataGridViewTextBoxColumn chapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn percentStr;
        private System.Windows.Forms.DataGridViewTextBoxColumn time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Percent;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaxPageNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn nowPageNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Url;




    }
}