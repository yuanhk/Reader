namespace Read.form
{
    partial class BaseForm
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
            this.minLabel = new System.Windows.Forms.Label();
            this.closeLabel = new System.Windows.Forms.Label();
            this.messageBox = new System.Windows.Forms.TextBox();
            this.separationLine = new System.Windows.Forms.Panel();
            this.scapegoat = new System.Windows.Forms.TextBox();
            this.titleBox = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // minLabel
            // 
            this.minLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.minLabel.AutoSize = true;
            this.minLabel.BackColor = System.Drawing.Color.Transparent;
            this.minLabel.Font = new System.Drawing.Font("微软雅黑", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.minLabel.ForeColor = System.Drawing.Color.Gray;
            this.minLabel.Location = new System.Drawing.Point(700, 6);
            this.minLabel.Name = "minLabel";
            this.minLabel.Size = new System.Drawing.Size(19, 16);
            this.minLabel.TabIndex = 75;
            this.minLabel.Tag = "最小化";
            this.minLabel.Text = "—";
            this.minLabel.Click += new System.EventHandler(this.UpperRightCorner_Click);
            this.minLabel.MouseEnter += new System.EventHandler(this.UpperRightCorner_MouseEnter);
            this.minLabel.MouseLeave += new System.EventHandler(this.UpperRightCorner_MouseLeave);
            this.minLabel.MouseHover += new System.EventHandler(this.UpperRightCorner_MouseHover);
            // 
            // closeLabel
            // 
            this.closeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.closeLabel.AutoSize = true;
            this.closeLabel.BackColor = System.Drawing.Color.Transparent;
            this.closeLabel.Font = new System.Drawing.Font("微软雅黑", 14.5F);
            this.closeLabel.ForeColor = System.Drawing.Color.Gray;
            this.closeLabel.Location = new System.Drawing.Point(722, 1);
            this.closeLabel.Name = "closeLabel";
            this.closeLabel.Size = new System.Drawing.Size(27, 27);
            this.closeLabel.TabIndex = 74;
            this.closeLabel.Tag = "关闭";
            this.closeLabel.Text = "×";
            this.closeLabel.Click += new System.EventHandler(this.UpperRightCorner_Click);
            this.closeLabel.MouseEnter += new System.EventHandler(this.UpperRightCorner_MouseEnter);
            this.closeLabel.MouseLeave += new System.EventHandler(this.UpperRightCorner_MouseLeave);
            this.closeLabel.MouseHover += new System.EventHandler(this.UpperRightCorner_MouseHover);
            // 
            // messageBox
            // 
            this.messageBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.messageBox.BackColor = System.Drawing.Color.White;
            this.messageBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.messageBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.messageBox.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.messageBox.ForeColor = System.Drawing.Color.Tomato;
            this.messageBox.Location = new System.Drawing.Point(52, 8);
            this.messageBox.Name = "messageBox";
            this.messageBox.ReadOnly = true;
            this.messageBox.Size = new System.Drawing.Size(275, 18);
            this.messageBox.TabIndex = 76;
            this.messageBox.TabStop = false;
            this.messageBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.messageBox.Visible = false;
            // 
            // separationLine
            // 
            this.separationLine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.separationLine.BackColor = System.Drawing.Color.Black;
            this.separationLine.Location = new System.Drawing.Point(10, 32);
            this.separationLine.Name = "separationLine";
            this.separationLine.Size = new System.Drawing.Size(730, 1);
            this.separationLine.TabIndex = 77;
            // 
            // scapegoat
            // 
            this.scapegoat.Location = new System.Drawing.Point(1, 674);
            this.scapegoat.Name = "scapegoat";
            this.scapegoat.Size = new System.Drawing.Size(144, 23);
            this.scapegoat.TabIndex = 1;
            this.scapegoat.Text = "这是用来接收鼠标焦点的";
            // 
            // titleBox
            // 
            this.titleBox.AutoSize = true;
            this.titleBox.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.titleBox.Location = new System.Drawing.Point(9, 7);
            this.titleBox.Name = "titleBox";
            this.titleBox.Size = new System.Drawing.Size(37, 20);
            this.titleBox.TabIndex = 78;
            this.titleBox.Text = "标题";
            // 
            // BaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 490);
            this.Controls.Add(this.titleBox);
            this.Controls.Add(this.scapegoat);
            this.Controls.Add(this.separationLine);
            this.Controls.Add(this.messageBox);
            this.Controls.Add(this.minLabel);
            this.Controls.Add(this.closeLabel);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "BaseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "BaseForm";
            this.Load += new System.EventHandler(this.BaseForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Base_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Base_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Base_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label minLabel;
        public System.Windows.Forms.Label closeLabel;
        public System.Windows.Forms.TextBox messageBox;
        public System.Windows.Forms.TextBox scapegoat;
        public System.Windows.Forms.Panel separationLine;
        public System.Windows.Forms.Label titleBox;
    }
}