using Read.model;
using Read.plugin;
using Read.service;
using Reader.model;
using Reader.services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Read.form
{
    public partial class SettingForm : BaseForm
    {
        MainForm mainForm;


        public SettingForm(MainForm m)
        {
            InitializeComponent();
            mainForm = m;
        }
        List<PresetColor> presets = null;


        float fontPt = Setting.get().FontSize;

        private void Main_Load(object sender, EventArgs e)
        {
            titleBox.Text = "设置";
            loadSetting();
            backColorBox.box.KeyUp += box_TextChanged;
            foreColorBox.box.KeyUp += box_TextChanged;
            tipColorBox.box.KeyUp += box_TextChanged;
            //加载默认配色
            presets = LoadXmlService.getDefault<PresetColor>();
            foreach (PresetColor c in presets)
            {
                skinTypeCmb.Items.Add(c.Name);
            }
        }

        private void loadSetting()
        {
            Setting set = Setting.get();
            //获取系统字体(字体名必须含汉字)：
            InstalledFontCollection fc = new InstalledFontCollection();
            fontStyleCmb.Items.Clear();
            foreach (FontFamily font in fc.Families)
            {
                if (Regex.IsMatch(font.Name, @"[\u4e00-\u9fa5]"))
                {
                    this.fontStyleCmb.Items.Add(font.Name);
                    if (font.Name.Equals(set.FontStyle))
                        this.fontStyleCmb.SelectedIndex = this.fontStyleCmb.Items.Count - 1;
                }
            }
            fontSizeLabel.Text = Common.toPx(fontPt) + "";
            backColorBox.BackColor = backColor;
            backColorBox.box.ContextMenuStrip = selectColor;
            backColorBox.box.TextChanged += box_TextChanged;

            foreColorBox.BackColor = foreColor;
            foreColorBox._borderC = foreColor;
            foreColorBox.box.ContextMenuStrip = selectColor;

            tipColorBox.BackColor = tipColor;
            tipColorBox._borderC = foreColor;
            tipColorBox.box.ContextMenuStrip = selectColor;

            showChangeBox.BackColor = backColor;
            showChangeBox.ForeColor = foreColor;
        }

        private void box_TextChanged(object sender, EventArgs e)
        {
            TextBox ex = (TextBox)sender;
            ex.BackColor = ColorUtil.colorHx16toRGB(ex.Text, Color.Black);
            ex.Parent.BackColor = ex.BackColor;
        }


        private void fontLess_Click(object sender, EventArgs e)
        {
            int fontPx = Common.toInt(fontSizeLabel.Text, 6);
            if (fontPx > 6)
                fontSizeLabel.Text = --fontPx + "";
        }

        private void fontPlus_Click(object sender, EventArgs e)
        {
            int fontPx = Common.toInt(fontSizeLabel.Text, 20);
            if (fontPx < 20)
                fontSizeLabel.Text = ++fontPx + "";
        }

        private void fontSizePx_TextChanged(object sender, EventArgs e)
        {
            fontPt = Common.toPt(Common.toInt(fontSizeLabel.Text));
            showChangeBox.Font = new Font(fontStyleCmb.Text, fontPt, showChangeBox.Font.Style);
        }

        private void buttonEx3_Click(object sender, EventArgs e)
        {
            Boolean b = alert("提示", "\r\n\r\n确定放弃当前变更的设置？");
            if (b)
            {
                loadSetting();
                showMessage("已恢复变更前的设置");
            }
        }

        private void backColorBox_BackColorChanged(object sender, EventArgs e)
        {
            TextBoxEx box = (TextBoxEx)sender;
            box.box.Text = ColorUtil.ToHexColor(box.BackColor);
            if (box == backColorBox)
            {
                label9.BackColor = backColorBox.BackColor;
                showChangeBox.BackColor = backColorBox.BackColor;
                showChangePanel.BackColor = backColorBox.BackColor;
                box.ForeColor = foreColorBox.BackColor;
            }
            else if (box == foreColorBox)
            {
                showChangeBox.ForeColor = foreColorBox.BackColor;
                box.ForeColor = backColorBox.BackColor;
                backColorBox.ForeColor = foreColorBox.BackColor;
            }
            else
            {
                box.ForeColor = backColorBox.BackColor;
                label9.ForeColor = tipColorBox.BackColor;
            }

        }

        TextBox updateColorBox = null;

        private void 选择颜色ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog1 = new ColorDialog();
            colorDialog1.FullOpen = true; //是否显示ColorDialog有半部分，运行一下就很了然了
            DialogResult result = colorDialog1.ShowDialog();
            if (result == DialogResult.OK)//确定事件响应
            {
                Color color_from = colorDialog1.Color;
                updateColorBox.BackColor = colorDialog1.Color;
            }
        }

        private void selectColor_Opening(object sender, CancelEventArgs e)
        {
            updateColorBox = (TextBox)(sender as ContextMenuStrip).SourceControl;
        }

        private void fontStyleCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            showChangeBox.Font = new Font(fontStyleCmb.Text, fontPt, showChangeBox.Font.Style);
        }

        private void buttonEx5_Click(object sender, EventArgs e)
        {
            Boolean b = alert("提示", "\r\n\r\n确定应用当前变更的设置？");
            if (b)
            {
                this.DoWorkAsync((o) =>
                {
                    Setting s = Setting.get();
                    //判断字体大小或样式是否变更
                    bool isChange = s.FontSize != fontPt || s.FontStyle != fontStyleCmb.Text; ;
                    s.FontSize = fontPt;
                    s.BackColor = backColorBox.box.Text;
                    s.ForeColor = foreColorBox.box.Text;
                    s.MessageColor = tipColorBox.box.Text;
                    s.FontStyle = fontStyleCmb.Text;
                    Setting.save();

                    this.ResetStting();
                    this.loadSetting();

                    //重新读取文本
                    mainForm.ResetStting();
                    //文字大小变更后重载
                    if (isChange)
                    {
                        mainForm.loadLastRead();
                    }
                    return null;
                }, null, (r) =>
                {
                    showMessage("保存并应用设置成功");
                    mainForm.bookText.Show();
                });
            }
        }

        private void skinTypeCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (presets.Count > skinTypeCmb.SelectedIndex)
            {
                PresetColor color = presets[skinTypeCmb.SelectedIndex];
                backColorBox.BackColor = ColorUtil.colorHx16toRGB(color.BackColor, backColorBox.BackColor);
                foreColorBox.BackColor = ColorUtil.colorHx16toRGB(color.ForeColor, foreColorBox.BackColor);
                tipColorBox.BackColor = ColorUtil.colorHx16toRGB(color.MessageColor, tipColorBox.BackColor);
                showMessage("已加载" + color.Name + "配色");
            }
        }

        private void buttonEx5_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
