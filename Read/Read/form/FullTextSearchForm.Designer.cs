namespace Read.form
{
    partial class FullTextSearchForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FullTextSearchForm));
            this.fullSearchDgv = new System.Windows.Forms.DataGridView();
            this.章节 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CatalogNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.页码 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statisticsTB = new System.Windows.Forms.TextBox();
            this.sreachLabel = new System.Windows.Forms.Label();
            this.UnderscoreBox = new System.Windows.Forms.Panel();
            this.sreachText = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.fullSearchDgv)).BeginInit();
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
            // 
            // scapegoat
            // 
            this.scapegoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(63)))), ((int)(((byte)(80)))));
            this.scapegoat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(181)))), ((int)(((byte)(182)))));
            this.scapegoat.Visible = false;
            // 
            // separationLine
            // 
            this.separationLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(181)))), ((int)(((byte)(182)))));
            this.separationLine.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(181)))), ((int)(((byte)(182)))));
            this.separationLine.Location = new System.Drawing.Point(8, 32);
            // 
            // titleBox
            // 
            this.titleBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(63)))), ((int)(((byte)(80)))));
            this.titleBox.ForeColor = System.Drawing.Color.Tomato;
            // 
            // fullSearchDgv
            // 
            this.fullSearchDgv.AllowUserToAddRows = false;
            this.fullSearchDgv.AllowUserToDeleteRows = false;
            this.fullSearchDgv.AllowUserToResizeColumns = false;
            this.fullSearchDgv.AllowUserToResizeRows = false;
            this.fullSearchDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.fullSearchDgv.BackgroundColor = System.Drawing.SystemColors.Control;
            this.fullSearchDgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.fullSearchDgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.fullSearchDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.fullSearchDgv.ColumnHeadersVisible = false;
            this.fullSearchDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.章节,
            this.CatalogNo,
            this.页码});
            this.fullSearchDgv.Location = new System.Drawing.Point(8, 39);
            this.fullSearchDgv.MultiSelect = false;
            this.fullSearchDgv.Name = "fullSearchDgv";
            this.fullSearchDgv.ReadOnly = true;
            this.fullSearchDgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.fullSearchDgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.fullSearchDgv.RowTemplate.Height = 23;
            this.fullSearchDgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.fullSearchDgv.Size = new System.Drawing.Size(730, 424);
            this.fullSearchDgv.TabIndex = 92;
            this.fullSearchDgv.DoubleClick += new System.EventHandler(this.fullSearchDgv_DoubleClick);
            // 
            // 章节
            // 
            this.章节.DataPropertyName = "Chapter";
            this.章节.FillWeight = 28F;
            this.章节.HeaderText = "章节";
            this.章节.MinimumWidth = 30;
            this.章节.Name = "章节";
            this.章节.ReadOnly = true;
            // 
            // CatalogNo
            // 
            this.CatalogNo.DataPropertyName = "Preview";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.CatalogNo.DefaultCellStyle = dataGridViewCellStyle2;
            this.CatalogNo.FillWeight = 65F;
            this.CatalogNo.HeaderText = "预览";
            this.CatalogNo.MinimumWidth = 80;
            this.CatalogNo.Name = "CatalogNo";
            this.CatalogNo.ReadOnly = true;
            // 
            // 页码
            // 
            this.页码.DataPropertyName = "PageNum";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.页码.DefaultCellStyle = dataGridViewCellStyle3;
            this.页码.FillWeight = 7F;
            this.页码.HeaderText = "页码";
            this.页码.MinimumWidth = 20;
            this.页码.Name = "页码";
            this.页码.ReadOnly = true;
            // 
            // statisticsTB
            // 
            this.statisticsTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.statisticsTB.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.statisticsTB.Location = new System.Drawing.Point(604, 471);
            this.statisticsTB.Name = "statisticsTB";
            this.statisticsTB.ReadOnly = true;
            this.statisticsTB.Size = new System.Drawing.Size(136, 16);
            this.statisticsTB.TabIndex = 96;
            this.statisticsTB.Text = "共计：0 条";
            this.statisticsTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // sreachLabel
            // 
            this.sreachLabel.AutoSize = true;
            this.sreachLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sreachLabel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sreachLabel.Location = new System.Drawing.Point(375, 7);
            this.sreachLabel.Name = "sreachLabel";
            this.sreachLabel.Size = new System.Drawing.Size(39, 17);
            this.sreachLabel.TabIndex = 102;
            this.sreachLabel.Tag = "输入检索文本后单击";
            this.sreachLabel.Text = "查找 :";
            this.sreachLabel.Click += new System.EventHandler(this.sreachLabel_Click);
            this.sreachLabel.MouseHover += new System.EventHandler(this.sreachLabel_MouseHover);
            // 
            // UnderscoreBox
            // 
            this.UnderscoreBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.UnderscoreBox.ForeColor = System.Drawing.Color.Red;
            this.UnderscoreBox.Location = new System.Drawing.Point(377, 26);
            this.UnderscoreBox.Name = "UnderscoreBox";
            this.UnderscoreBox.Size = new System.Drawing.Size(230, 1);
            this.UnderscoreBox.TabIndex = 101;
            // 
            // sreachText
            // 
            this.sreachText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sreachText.Location = new System.Drawing.Point(418, 7);
            this.sreachText.Name = "sreachText";
            this.sreachText.Size = new System.Drawing.Size(187, 16);
            this.sreachText.TabIndex = 100;
            this.sreachText.Tag = "回车键确定或单击查找按钮";
            this.sreachText.TextChanged += new System.EventHandler(this.sreachText_TextChanged);
            this.sreachText.KeyUp += new System.Windows.Forms.KeyEventHandler(this.sreachText_KeyUp);
            this.sreachText.MouseHover += new System.EventHandler(this.sreachText_MouseHover);
            // 
            // FullTextSearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 490);
            this.Controls.Add(this.sreachLabel);
            this.Controls.Add(this.UnderscoreBox);
            this.Controls.Add(this.sreachText);
            this.Controls.Add(this.statisticsTB);
            this.Controls.Add(this.fullSearchDgv);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(181)))), ((int)(((byte)(182)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FullTextSearchForm";
            this.Text = "全文检索";
            this.Load += new System.EventHandler(this.Mainsdasd_Load);
            this.Controls.SetChildIndex(this.titleBox, 0);
            this.Controls.SetChildIndex(this.closeLabel, 0);
            this.Controls.SetChildIndex(this.minLabel, 0);
            this.Controls.SetChildIndex(this.messageBox, 0);
            this.Controls.SetChildIndex(this.separationLine, 0);
            this.Controls.SetChildIndex(this.scapegoat, 0);
            this.Controls.SetChildIndex(this.fullSearchDgv, 0);
            this.Controls.SetChildIndex(this.statisticsTB, 0);
            this.Controls.SetChildIndex(this.sreachText, 0);
            this.Controls.SetChildIndex(this.UnderscoreBox, 0);
            this.Controls.SetChildIndex(this.sreachLabel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fullSearchDgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView fullSearchDgv;
        private System.Windows.Forms.TextBox statisticsTB;
        private System.Windows.Forms.DataGridViewTextBoxColumn 章节;
        private System.Windows.Forms.DataGridViewTextBoxColumn CatalogNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn 页码;
        private System.Windows.Forms.Label sreachLabel;
        private System.Windows.Forms.Panel UnderscoreBox;
        private System.Windows.Forms.TextBox sreachText;
    }
}