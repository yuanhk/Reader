using Orange.control;
using Read.service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Read.plugin
{
    class TextBoxEx : PanelEx
    {
        public TextBoxEx()
           : base()
        {
            init();
        }

    
       
        public TextBox box;
        private void init()
        {
            this.Width = 120;
            this.Height = 25;
            this.Radius = 2;
            this._roundeStyle = RoundStyle.All;
            this.BackColor = Color.Transparent;
           
            this.box = new TextBox();
            this.box.BorderStyle = BorderStyle.None;
            this.box.Anchor = ((AnchorStyles)((((AnchorStyles.Top | AnchorStyles.Bottom) | AnchorStyles.Left)| AnchorStyles.Right)));
            this.box.AutoSize = false;
            this.box.BackColor = Color.White;
            this.box.Font = this.Font;
            this.box.ForeColor = this.ForeColor;
            this.box.Text = "";
            this.MouseEnter += new System.EventHandler(this._MouseEnter);
            this.MouseLeave += new System.EventHandler(this._MouseLeave);
            this.box.TextChanged += new System.EventHandler(this._TextChanged);
            this.box.MouseEnter += new System.EventHandler(this._MouseEnter);
            this.box.MouseLeave += new System.EventHandler(this._MouseLeave);
            this.box.BackColorChanged += new System.EventHandler(this._BackColorChanged);
            this.ForeColorChanged += new System.EventHandler(this._ForeColorChanged);
            this.Controls.Add(this.box);
        }

        public  Color _borderC = Color.Transparent;

        private void _ForeColorChanged(object sender, EventArgs e)
        {
            this.box.ForeColor = this.ForeColor;
        }

        private void _BackColorChanged(object sender, EventArgs e)
        {
            this.BackColor = this.box.BackColor;
        }

        private void _TextChanged(object sender, EventArgs e)
        {
            this.Text = this.box.Text;
        }

        private void _MouseEnter(object sender, EventArgs e)
        {
            if (_borderC==Color.Transparent)
            {
             _borderC = ForeColor;
            }
            this.BorderColor = ColorUtil.ChangeColor(_borderC, -0.25f);
        }

        private void _MouseLeave(object sender, EventArgs e)
        {
            this.BorderColor = _borderC;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            int left = 3;
            int top = (this.Height - Font.Height)/2;

            this.box.Location = new System.Drawing.Point(left, top);
            if (!this.BackColor.Equals(Color.Transparent))
            {
                box.BackColor = this.BackColor;
            }
            box.Width = this.Width - 6;
            box.Height = Font.Height;
            this.box.Font = Font;
            this.box.ForeColor = this.ForeColor;
        }
    }
}
