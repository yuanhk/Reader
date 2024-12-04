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
    class ButtonEx : PanelEx
    {


        private String _text;
        [DefaultValue(typeof(String), "按钮"), Description("按钮显示文本")]
        public String text
        {
            get { return _text; }
            set
            {
                _text = value;
                base.Invalidate();
            }
        }
        /// <summary>
        /// 自定义禁用方法，保持禁用后样式不变
        /// </summary>
        /// <param name="hWnd"></param>
        /// <param name="nIndex"></param>
        /// <param name="wndproc"></param>
        /// <returns></returns>
        [System.Runtime.InteropServices.DllImport("user32.dll ")]
        public static extern int SetWindowLong(IntPtr hWnd, int nIndex, int wndproc);
        [System.Runtime.InteropServices.DllImport("user32.dll ")]
        public static extern int GetWindowLong(IntPtr hWnd, int nIndex);

        public const int GWL_STYLE = -16;
        public const int WS_DISABLED = 0x8000000;

        public static void SetControlEnabled(Control c, bool enabled)
        {
            if (enabled)
            { SetWindowLong(c.Handle, GWL_STYLE, (~WS_DISABLED) & GetWindowLong(c.Handle, GWL_STYLE)); }
            else
            { SetWindowLong(c.Handle, GWL_STYLE, WS_DISABLED + GetWindowLong(c.Handle, GWL_STYLE)); }
        }



        public ButtonEx()
            : base()
        {
            init();
        }

        public Label label;
        private void init()
        {
            _text = "按钮";
            this.Width = 75;
            this.Height = 25;
            this.Radius = 2;
            this._roundeStyle = RoundStyle.All;
            this.Cursor = Cursors.Hand;
            this.BackColor = Color.Transparent;

            this.label = new Label();
            this.label.Anchor = ((AnchorStyles)((((AnchorStyles.Top | AnchorStyles.Bottom)| AnchorStyles.Left) | AnchorStyles.Right)));
            this.label.AutoSize = true;
            this.label.BackColor = Color.Transparent;
            this.label.Font = this.Font;
            this.label.ForeColor = this.ForeColor;
            this.label.Tag = _text;
            this.label.Text = _text;
            this.MouseEnter += new EventHandler(this._MouseEnter);
            this.MouseLeave += new EventHandler(this._MouseLeave);
            //禁用label，避免单击label时不触发panel的单击事件
            SetControlEnabled(this.label, false);
            this.Controls.Add(this.label);


        }

        /// <summary>
        /// 面板移入移出时边框和文字颜色变暗
        /// </summary>
        private Color oldColor = Color.Gray;

        private void _MouseEnter(object sender, EventArgs e)
        {

            oldColor = ForeColor;

            this.ForeColor = ColorUtil.ChangeColor(ForeColor, -0.25f);
            this.BorderColor = this.ForeColor;
        }

        private void _MouseLeave(object sender, EventArgs e)
        {
            this.ForeColor = oldColor;
            this.BorderColor = this.ForeColor;
        }


        /// <summary>
        /// 重绘时label随之变化
        /// </summary>
        /// <param name="e"></param>
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            int left = (this.Width - label.Width) / 2;
            int top = (this.Height - label.Height) / 2;

            this.label.Location = new Point(left, top);
            this.label.Font = Font;
            this.label.ForeColor = this.ForeColor;
            this.label.Text = _text;
        }

       
    }

}
