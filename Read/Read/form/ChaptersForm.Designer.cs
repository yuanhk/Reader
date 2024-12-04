namespace Read.form
{
    partial class ChaptersForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChaptersForm));
            this.catalogDgv = new System.Windows.Forms.DataGridView();
            this.CatalogNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CatalogName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.进度 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.页码 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filterTB = new System.Windows.Forms.TextBox();
            this.UnderscoreBox = new System.Windows.Forms.Panel();
            this.sreachLabel = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.刷新ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.catalogDgv)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // minLabel
            // 
            this.minLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(63)))), ((int)(((byte)(80)))));
            this.minLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(181)))), ((int)(((byte)(182)))));
            this.minLabel.Location = new System.Drawing.Point(696, 7);
            // 
            // closeLabel
            // 
            this.closeLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(63)))), ((int)(((byte)(80)))));
            this.closeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(181)))), ((int)(((byte)(182)))));
            this.closeLabel.Location = new System.Drawing.Point(721, 2);
            // 
            // messageBox
            // 
            this.messageBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(63)))), ((int)(((byte)(80)))));
            this.messageBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(99)))), ((int)(((byte)(71)))));
            this.messageBox.Location = new System.Drawing.Point(86, 9);
            this.messageBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.messageBox.Size = new System.Drawing.Size(274, 18);
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
            this.separationLine.Location = new System.Drawing.Point(13, 35);
            this.separationLine.Size = new System.Drawing.Size(725, 1);
            // 
            // titleBox
            // 
            this.titleBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(63)))), ((int)(((byte)(80)))));
            this.titleBox.ForeColor = System.Drawing.Color.Tomato;
            // 
            // catalogDgv
            // 
            this.catalogDgv.AllowUserToAddRows = false;
            this.catalogDgv.AllowUserToDeleteRows = false;
            this.catalogDgv.AllowUserToResizeColumns = false;
            this.catalogDgv.AllowUserToResizeRows = false;
            this.catalogDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.catalogDgv.BackgroundColor = System.Drawing.SystemColors.Control;
            this.catalogDgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.catalogDgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.catalogDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.catalogDgv.ColumnHeadersVisible = false;
            this.catalogDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CatalogNo,
            this.CatalogName,
            this.进度,
            this.页码});
            this.catalogDgv.ContextMenuStrip = this.contextMenuStrip1;
            this.catalogDgv.Location = new System.Drawing.Point(12, 42);
            this.catalogDgv.MultiSelect = false;
            this.catalogDgv.Name = "catalogDgv";
            this.catalogDgv.ReadOnly = true;
            this.catalogDgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.catalogDgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.catalogDgv.RowTemplate.Height = 23;
            this.catalogDgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.catalogDgv.Size = new System.Drawing.Size(726, 436);
            this.catalogDgv.TabIndex = 15;
            this.catalogDgv.DataSourceChanged += new System.EventHandler(this.catalogDgv_DataSourceChanged);
            this.catalogDgv.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.catalogDgv_CellMouseDoubleClick);
            // 
            // CatalogNo
            // 
            this.CatalogNo.DataPropertyName = "CatalogNo";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.CatalogNo.DefaultCellStyle = dataGridViewCellStyle2;
            this.CatalogNo.FillWeight = 50F;
            this.CatalogNo.HeaderText = "章节";
            this.CatalogNo.Name = "CatalogNo";
            this.CatalogNo.ReadOnly = true;
            // 
            // CatalogName
            // 
            this.CatalogName.DataPropertyName = "CatalogName";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.CatalogName.DefaultCellStyle = dataGridViewCellStyle3;
            this.CatalogName.FillWeight = 200.1929F;
            this.CatalogName.HeaderText = "章节名";
            this.CatalogName.Name = "CatalogName";
            this.CatalogName.ReadOnly = true;
            // 
            // 进度
            // 
            this.进度.DataPropertyName = "PercentText";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.进度.DefaultCellStyle = dataGridViewCellStyle4;
            this.进度.FillWeight = 52.0171F;
            this.进度.HeaderText = "进度";
            this.进度.Name = "进度";
            this.进度.ReadOnly = true;
            // 
            // 页码
            // 
            this.页码.DataPropertyName = "PageNum";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.页码.DefaultCellStyle = dataGridViewCellStyle5;
            this.页码.FillWeight = 1F;
            this.页码.HeaderText = "页码";
            this.页码.Name = "页码";
            this.页码.ReadOnly = true;
            // 
            // filterTB
            // 
            this.filterTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.filterTB.Location = new System.Drawing.Point(418, 11);
            this.filterTB.Name = "filterTB";
            this.filterTB.Size = new System.Drawing.Size(187, 16);
            this.filterTB.TabIndex = 79;
            this.filterTB.TextChanged += new System.EventHandler(this.filterTB_TextChanged);
            // 
            // UnderscoreBox
            // 
            this.UnderscoreBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.UnderscoreBox.ForeColor = System.Drawing.Color.Red;
            this.UnderscoreBox.Location = new System.Drawing.Point(377, 30);
            this.UnderscoreBox.Name = "UnderscoreBox";
            this.UnderscoreBox.Size = new System.Drawing.Size(230, 1);
            this.UnderscoreBox.TabIndex = 80;
            // 
            // sreachLabel
            // 
            this.sreachLabel.AutoSize = true;
            this.sreachLabel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sreachLabel.Location = new System.Drawing.Point(375, 11);
            this.sreachLabel.Name = "sreachLabel";
            this.sreachLabel.Size = new System.Drawing.Size(39, 17);
            this.sreachLabel.TabIndex = 81;
            this.sreachLabel.Text = "查找 :";
            this.sreachLabel.Click += new System.EventHandler(this.sreachLabel_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.刷新ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 48);
            // 
            // 刷新ToolStripMenuItem
            // 
            this.刷新ToolStripMenuItem.Name = "刷新ToolStripMenuItem";
            this.刷新ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.刷新ToolStripMenuItem.Text = "刷新";
            this.刷新ToolStripMenuItem.Click += new System.EventHandler(this.刷新ToolStripMenuItem_Click);
            // 
            // ChaptersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 490);
            this.Controls.Add(this.sreachLabel);
            this.Controls.Add(this.UnderscoreBox);
            this.Controls.Add(this.filterTB);
            this.Controls.Add(this.catalogDgv);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(181)))), ((int)(((byte)(182)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.Name = "ChaptersForm";
            this.Text = "章节目录";
            this.Load += new System.EventHandler(this.Chapter_Load);
            this.Controls.SetChildIndex(this.catalogDgv, 0);
            this.Controls.SetChildIndex(this.filterTB, 0);
            this.Controls.SetChildIndex(this.UnderscoreBox, 0);
            this.Controls.SetChildIndex(this.sreachLabel, 0);
            this.Controls.SetChildIndex(this.separationLine, 0);
            this.Controls.SetChildIndex(this.messageBox, 0);
            this.Controls.SetChildIndex(this.scapegoat, 0);
            this.Controls.SetChildIndex(this.closeLabel, 0);
            this.Controls.SetChildIndex(this.minLabel, 0);
            this.Controls.SetChildIndex(this.titleBox, 0);
            ((System.ComponentModel.ISupportInitialize)(this.catalogDgv)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView catalogDgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn CatalogNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CatalogName;
        private System.Windows.Forms.DataGridViewTextBoxColumn 进度;
        private System.Windows.Forms.DataGridViewTextBoxColumn 页码;
        private System.Windows.Forms.TextBox filterTB;
        private System.Windows.Forms.Panel UnderscoreBox;
        private System.Windows.Forms.Label sreachLabel;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 刷新ToolStripMenuItem;
    }
}