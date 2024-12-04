using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
namespace WindowsApplication8
{
    /// <summary>
    /// 修改菜单栏边框和背景颜色
    /// </summary>
    class MenuBarColor : ProfessionalColorTable
    {
        Color ManuBarCommonColor = Color.Transparent;
        Color SelectedHighlightColor = Color.Transparent;
        Color MenuBorderColor = Color.Transparent;
        Color MenuItemBorderColor = Color.Coral;
        /// <summary> 
        /// Initialize a new instance of the Visual Studio MenuBarColor class. 
        /// </summary> 
        public MenuBarColor(Color a)
        {
            MenuItemBorderColor = a;
        }
        #region
        public override Color MenuItemPressedGradientBegin
        {
            get
            {
                return ManuBarCommonColor;
            }
        }
        public override Color MenuItemPressedGradientEnd
        {
            get
            {
                return ManuBarCommonColor;
            }
        }
        public override Color MenuItemPressedGradientMiddle
        {
            get
            {
                return ManuBarCommonColor;
            }
        }
        public override Color ButtonSelectedHighlight
        {
            get
            {
                return ManuBarCommonColor;
            }
        }
        public override Color MenuItemSelectedGradientBegin
        {
            get
            {
                return ManuBarCommonColor;
            }
        }
        public override Color MenuItemSelectedGradientEnd
        {
            get
            {
                return ManuBarCommonColor;
            }
        }
        public override Color MenuBorder
        {
            get
            {
                return MenuBorderColor;
            }
        }
        public override Color MenuItemBorder
        {
            get
            {
                return MenuItemBorderColor;
            }
        }
        #endregion
    }
    class MenuItemRenderer : ToolStripProfessionalRenderer
    {
        //文字を設定
        Font textFont = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        private Color menuItemSelectedColor = Color.Gray;
        private Color menuItemBorderColor = Color.Black;
        /// <summary> 
        /// Initialize a new instance of the Visual Studio MenuBarRenderer class. 
        /// </summary> 
        public MenuItemRenderer(Font f,Color c): base(new MenuBarColor(c)) 
        {
            textFont = f;
            this.menuItemSelectedColor = Color.Red;
            this.menuItemBorderColor = Color.Blue;
        }
        protected override void OnRenderItemText(ToolStripItemTextRenderEventArgs e)
        {
            e.TextFont = textFont;
            if (e.Item.IsOnDropDown)
            {
                if (e.Item.Selected)
                {
                    e.TextColor = Color.White;
                }
                else
                {
                    e.TextColor = Color.Black;
                }
            }
            base.OnRenderItemText(e);
        }
        #region Backgrounds
        protected override void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs e)
        {
            if (e.Item.IsOnDropDown)
            {
                if (e.Item.Selected == true && e.Item.Enabled)
                {
                    DrawMenuDropDownItemHighlight(e);
                }
            }
            else
            {
                base.OnRenderMenuItemBackground(e);
            }
        }
        #endregion
        #region DrawMenuDropDownItemHighlight
        private void DrawMenuDropDownItemHighlight(ToolStripItemRenderEventArgs e)
        {
            Rectangle rect = new Rectangle();
            rect = new Rectangle(2, 0, (int)e.Graphics.VisibleClipBounds.Width - 4, (int)e.Graphics.VisibleClipBounds.Height - 1);
            using (SolidBrush brush = new SolidBrush(menuItemSelectedColor))
            {
                e.Graphics.FillRectangle(brush, rect);
            }
            using (Pen pen = new Pen(menuItemBorderColor))
            {
                e.Graphics.DrawRectangle(pen, rect);
            }
        }
        #endregion
    }
}