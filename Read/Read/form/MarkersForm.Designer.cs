namespace Read.form
{
    partial class MarkersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MarkersForm));
            this.markerRightMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.继续阅读ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.手动选择ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.移除失效书籍ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.markerDgv = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chapter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.percentStr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Percent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaxPageNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nowPageNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Url = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.markerRightMenu.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.markerDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // minLabel
            // 
            this.minLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(63)))), ((int)(((byte)(80)))));
            this.minLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(181)))), ((int)(((byte)(182)))));
            this.minLabel.Location = new System.Drawing.Point(698, 7);
            // 
            // closeLabel
            // 
            this.closeLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(63)))), ((int)(((byte)(80)))));
            this.closeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(181)))), ((int)(((byte)(182)))));
            this.closeLabel.Location = new System.Drawing.Point(722, 2);
            // 
            // messageBox
            // 
            this.messageBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(63)))), ((int)(((byte)(80)))));
            this.messageBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(99)))), ((int)(((byte)(71)))));
            this.messageBox.Location = new System.Drawing.Point(86, 9);
            this.messageBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.messageBox.Size = new System.Drawing.Size(275, 18);
            // 
            // scapegoat
            // 
            this.scapegoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(63)))), ((int)(((byte)(80)))));
            this.scapegoat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(181)))), ((int)(((byte)(182)))));
            this.scapegoat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            // 
            // separationLine
            // 
            this.separationLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(181)))), ((int)(((byte)(182)))));
            this.separationLine.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(181)))), ((int)(((byte)(182)))));
            // 
            // titleBox
            // 
            this.titleBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(63)))), ((int)(((byte)(80)))));
            this.titleBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(181)))), ((int)(((byte)(182)))));
            // 
            // markerRightMenu
            // 
            this.markerRightMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.继续阅读ToolStripMenuItem,
            this.删除ToolStripMenuItem});
            this.markerRightMenu.Name = "markerRightMenu";
            this.markerRightMenu.Size = new System.Drawing.Size(125, 48);
            // 
            // 继续阅读ToolStripMenuItem
            // 
            this.继续阅读ToolStripMenuItem.Name = "继续阅读ToolStripMenuItem";
            this.继续阅读ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.继续阅读ToolStripMenuItem.Text = "继续阅读";
            this.继续阅读ToolStripMenuItem.Click += new System.EventHandler(this.继续阅读ToolStripMenuItem_Click);
            // 
            // 删除ToolStripMenuItem
            // 
            this.删除ToolStripMenuItem.Name = "删除ToolStripMenuItem";
            this.删除ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.删除ToolStripMenuItem.Text = "删除书签";
            this.删除ToolStripMenuItem.Click += new System.EventHandler(this.删除ToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.手动选择ToolStripMenuItem,
            this.移除失效书籍ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(375, 4);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 25);
            this.menuStrip1.TabIndex = 75;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 手动选择ToolStripMenuItem
            // 
            this.手动选择ToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.手动选择ToolStripMenuItem.Name = "手动选择ToolStripMenuItem";
            this.手动选择ToolStripMenuItem.Size = new System.Drawing.Size(92, 21);
            this.手动选择ToolStripMenuItem.Text = "删除选定书签";
            this.手动选择ToolStripMenuItem.Click += new System.EventHandler(this.手动选择ToolStripMenuItem_Click);
            // 
            // 移除失效书籍ToolStripMenuItem
            // 
            this.移除失效书籍ToolStripMenuItem.Name = "移除失效书籍ToolStripMenuItem";
            this.移除失效书籍ToolStripMenuItem.Size = new System.Drawing.Size(92, 21);
            this.移除失效书籍ToolStripMenuItem.Text = "清除失效书签";
            this.移除失效书籍ToolStripMenuItem.Click += new System.EventHandler(this.移除失效书籍ToolStripMenuItem_Click);
            // 
            // markerDgv
            // 
            this.markerDgv.AllowUserToAddRows = false;
            this.markerDgv.AllowUserToDeleteRows = false;
            this.markerDgv.AllowUserToResizeColumns = false;
            this.markerDgv.AllowUserToResizeRows = false;
            this.markerDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.markerDgv.BackgroundColor = System.Drawing.SystemColors.Control;
            this.markerDgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.markerDgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.markerDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.markerDgv.ColumnHeadersVisible = false;
            this.markerDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.chapter,
            this.percentStr,
            this.Percent,
            this.MaxPageNum,
            this.nowPageNum,
            this.Url,
            this.time});
            this.markerDgv.ContextMenuStrip = this.markerRightMenu;
            this.markerDgv.Location = new System.Drawing.Point(10, 39);
            this.markerDgv.Name = "markerDgv";
            this.markerDgv.ReadOnly = true;
            this.markerDgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.markerDgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.markerDgv.RowTemplate.Height = 23;
            this.markerDgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.markerDgv.Size = new System.Drawing.Size(728, 439);
            this.markerDgv.TabIndex = 93;
            this.markerDgv.SelectionChanged += new System.EventHandler(this.markerDgv_SelectionChanged);
            this.markerDgv.DoubleClick += new System.EventHandler(this.markerDgv_DoubleClick);
            // 
            // name
            // 
            this.name.DataPropertyName = "BookName";
            this.name.FillWeight = 82.65521F;
            this.name.HeaderText = "书名";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // chapter
            // 
            this.chapter.DataPropertyName = "Preview";
            this.chapter.FillWeight = 154.9785F;
            this.chapter.HeaderText = "章节或预览";
            this.chapter.Name = "chapter";
            this.chapter.ReadOnly = true;
            // 
            // percentStr
            // 
            this.percentStr.DataPropertyName = "PercentStr";
            this.percentStr.FillWeight = 30.9957F;
            this.percentStr.HeaderText = "阅读进度(显示)";
            this.percentStr.Name = "percentStr";
            this.percentStr.ReadOnly = true;
            // 
            // Percent
            // 
            this.Percent.DataPropertyName = "Percent";
            this.Percent.HeaderText = "进度";
            this.Percent.Name = "Percent";
            this.Percent.ReadOnly = true;
            this.Percent.Visible = false;
            // 
            // MaxPageNum
            // 
            this.MaxPageNum.DataPropertyName = "MaxPageNum";
            this.MaxPageNum.HeaderText = "最大页数";
            this.MaxPageNum.Name = "MaxPageNum";
            this.MaxPageNum.ReadOnly = true;
            this.MaxPageNum.Visible = false;
            // 
            // nowPageNum
            // 
            this.nowPageNum.DataPropertyName = "NowPageNum";
            this.nowPageNum.HeaderText = "当前页码";
            this.nowPageNum.Name = "nowPageNum";
            this.nowPageNum.ReadOnly = true;
            this.nowPageNum.Visible = false;
            // 
            // Url
            // 
            this.Url.DataPropertyName = "Url";
            this.Url.HeaderText = "文件路径";
            this.Url.Name = "Url";
            this.Url.ReadOnly = true;
            this.Url.Visible = false;
            // 
            // time
            // 
            this.time.DataPropertyName = "Time";
            this.time.FillWeight = 50F;
            this.time.HeaderText = "时间";
            this.time.Name = "time";
            this.time.ReadOnly = true;
            // 
            // MarkersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 490);
            this.Controls.Add(this.markerDgv);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(181)))), ((int)(((byte)(182)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.Name = "MarkersForm";
            this.Text = "书签";
            this.Load += new System.EventHandler(this.Marker_Load);
            this.Controls.SetChildIndex(this.titleBox, 0);
            this.Controls.SetChildIndex(this.separationLine, 0);
            this.Controls.SetChildIndex(this.messageBox, 0);
            this.Controls.SetChildIndex(this.scapegoat, 0);
            this.Controls.SetChildIndex(this.closeLabel, 0);
            this.Controls.SetChildIndex(this.minLabel, 0);
            this.Controls.SetChildIndex(this.menuStrip1, 0);
            this.Controls.SetChildIndex(this.markerDgv, 0);
            this.markerRightMenu.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.markerDgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.ToolStripMenuItem 手动选择ToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem 移除失效书籍ToolStripMenuItem;
        public System.Windows.Forms.ContextMenuStrip markerRightMenu;
        public System.Windows.Forms.ToolStripMenuItem 删除ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 继续阅读ToolStripMenuItem;
        public System.Windows.Forms.DataGridView markerDgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn chapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn percentStr;
        private System.Windows.Forms.DataGridViewTextBoxColumn Percent;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaxPageNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn nowPageNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Url;
        private System.Windows.Forms.DataGridViewTextBoxColumn time;
    }
}