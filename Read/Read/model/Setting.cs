using Reader.services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reader.model
{
    //设置
    public class Setting
    {

        private Int16 ruleType;//扫描章节严格程度 0:宽松 1：严格单章节 2：严格双章节

        public Int16 RuleType
        {
            get { return ruleType; }
            set { ruleType = value; }
        }
        private String rule;      //取章节字符

        public String Rule
        {
            get { return rule; }
            set { rule = value; }
        }
        private float fontSize;    //字体大小

        public float FontSize
        {
            get { return fontSize; }
            set { fontSize = value; }
        }
        private String backColor;  //背景色

        public String BackColor
        {
            get { return backColor; }
            set { backColor = value; }
        }
        private String foreColor;  //前景色

        public String ForeColor
        {
            get { return foreColor; }
            set { foreColor = value; }
        }

        private String messageColor;//消息颜色

        public String MessageColor
        {
            get { return messageColor; }
            set { messageColor = value; }
        }

        private String fontStyle;  //字体风格

        public String FontStyle
        {
            get { return fontStyle; }
            set { fontStyle = value; }
        }

        private Boolean autoHide; //自动隐藏

        public Boolean AutoHide
        {
            get { return autoHide; }
            set { autoHide = value; }
        }

        //缓存的设置
        private static Setting site = null;

        //获取设置
        public static Setting get()
        {
            if (site == null)
            {
                List<Setting> sites = LoadXmlService.getObj<Setting>();
                if (sites != null && sites.Count > 0)
                    site = sites[0];
                else
                    reSet();
            }

            return site;
        }

        //保存设置
        public static int save()
        {
            List<Setting> sites = new List<Setting>();
            sites.Add(get());
            return LoadXmlService.saveObj(sites);
        }

        //保存设置
        public static int save(Setting s)
        {
            site = s;
            return save();
        }

        public static int reSet()
        {
            Setting template = new Setting();
            template.BackColor = "#333F50";
            template.ForeColor = "#B4B5B6";
            template.messageColor = "#FF6347";
            template.FontSize = 10.5f;
            template.FontStyle = "微软雅黑";
            template.Rule = "章";
            template.ruleType = 1;
            template.AutoHide = false;
            site = template;
            return save();
        }
    }
}
