using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Read.model
{
    public class PresetColor
    {
        private String name;

        public String Name
        {
            get { return name; }
            set { name = value; }
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
    }
}
