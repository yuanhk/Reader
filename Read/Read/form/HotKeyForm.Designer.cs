namespace Read.form
{
    partial class HotKeyForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HotKeyForm));
            this.hotKeyDgv = new System.Windows.Forms.DataGridView();
            this.CatalogNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.章节 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.页码 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.全部重置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.hotKeyDgv)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // minLabel
            // 
            this.minLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(63)))), ((int)(((byte)(80)))));
            this.minLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(181)))), ((int)(((byte)(182)))));
            // 
            // closeLabel
            // 
            this.closeLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(63)))), ((int)(((byte)(80)))));
            this.closeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(181)))), ((int)(((byte)(182)))));
            // 
            // messageBox
            // 
            this.messageBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(63)))), ((int)(((byte)(80)))));
            this.messageBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(99)))), ((int)(((byte)(71)))));
            this.messageBox.Location = new System.Drawing.Point(86, 9);
            this.messageBox.Size = new System.Drawing.Size(275, 18);
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
            // 
            // titleBox
            // 
            this.titleBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(63)))), ((int)(((byte)(80)))));
            this.titleBox.ForeColor = System.Drawing.Color.Tomato;
            // 
            // hotKeyDgv
            // 
            this.hotKeyDgv.AllowUserToAddRows = false;
            this.hotKeyDgv.AllowUserToDeleteRows = false;
            this.hotKeyDgv.AllowUserToResizeColumns = false;
            this.hotKeyDgv.AllowUserToResizeRows = false;
            this.hotKeyDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.hotKeyDgv.BackgroundColor = System.Drawing.SystemColors.Control;
            this.hotKeyDgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.hotKeyDgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.hotKeyDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.hotKeyDgv.ColumnHeadersVisible = false;
            this.hotKeyDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CatalogNo,
            this.章节,
            this.页码});
            this.hotKeyDgv.ContextMenuStrip = this.contextMenuStrip1;
            this.hotKeyDgv.Location = new System.Drawing.Point(10, 39);
            this.hotKeyDgv.MultiSelect = false;
            this.hotKeyDgv.Name = "hotKeyDgv";
            this.hotKeyDgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.hotKeyDgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.hotKeyDgv.RowTemplate.Height = 23;
            this.hotKeyDgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.hotKeyDgv.Size = new System.Drawing.Size(728, 429);
            this.hotKeyDgv.TabIndex = 93;
            this.hotKeyDgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.hotKeyDgv_CellClick);
            this.hotKeyDgv.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.hotKeyDgv_CellValueChanged);
            this.hotKeyDgv.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.hotKeyDgv_EditingControlShowing);
            this.hotKeyDgv.KeyDown += new System.Windows.Forms.KeyEventHandler(this.hotKeyDgv_KeyDown);
            // 
            // CatalogNo
            // 
            this.CatalogNo.DataPropertyName = "effect";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.CatalogNo.DefaultCellStyle = dataGridViewCellStyle2;
            this.CatalogNo.FillWeight = 35F;
            this.CatalogNo.HeaderText = "对应功能";
            this.CatalogNo.Name = "CatalogNo";
            // 
            // 章节
            // 
            this.章节.DataPropertyName = "keyCode";
            this.章节.FillWeight = 35F;
            this.章节.HeaderText = "按键代码";
            this.章节.Name = "章节";
            // 
            // 页码
            // 
            this.页码.DataPropertyName = "details";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.页码.DefaultCellStyle = dataGridViewCellStyle3;
            this.页码.FillWeight = 50F;
            this.页码.HeaderText = "按键详情";
            this.页码.Name = "页码";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.全部重置ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(125, 26);
            // 
            // 全部重置ToolStripMenuItem
            // 
            this.全部重置ToolStripMenuItem.Name = "全部重置ToolStripMenuItem";
            this.全部重置ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.全部重置ToolStripMenuItem.Text = "全部重置";
            this.全部重置ToolStripMenuItem.Click += new System.EventHandler(this.全部重置ToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(209, 471);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(316, 17);
            this.label2.TabIndex = 94;
            this.label2.Text = "注意:全局热键均为组合键，规则为 Ctrl + Alt + 设置键码 ";
            // 
            // HotKeyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 490);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.hotKeyDgv);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(181)))), ((int)(((byte)(182)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HotKeyForm";
            this.ShowInTaskbar = false;
            this.Text = "快捷键设置";
            this.Load += new System.EventHandler(this.Main_Load);
            this.Controls.SetChildIndex(this.titleBox, 0);
            this.Controls.SetChildIndex(this.closeLabel, 0);
            this.Controls.SetChildIndex(this.minLabel, 0);
            this.Controls.SetChildIndex(this.messageBox, 0);
            this.Controls.SetChildIndex(this.separationLine, 0);
            this.Controls.SetChildIndex(this.scapegoat, 0);
            this.Controls.SetChildIndex(this.hotKeyDgv, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.hotKeyDgv)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView hotKeyDgv;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn CatalogNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn 章节;
        private System.Windows.Forms.DataGridViewTextBoxColumn 页码;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 全部重置ToolStripMenuItem;
    }
}