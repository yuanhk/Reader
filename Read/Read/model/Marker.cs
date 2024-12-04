using Reader.services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reader.model
{
    public class Marker
    {
        public String bookName;

        public String BookName
        {
            get { return bookName; }
            set { bookName = value; }
        }
        public String url;      //书籍地址

        public String Url
        {
            get { return url; }
            set { url = value; }
        }
        public double percent; //百分比

        public double Percent
        {
            get { return percent; }
            set { percent = value; }
        }

        public String percentStr; //百分比显示

        public String PercentStr
        {
            get
            {
                return Math.Round(percent, 2) + "%";
            }
            set { percentStr = value; }
        }

        public String preview; //章节或预览

        public String Preview
        {
            get { return preview; }
            set { preview = value; }
        }
        public String time;

        public String Time
        {
            get { return time; }
            set { time = value; }
        }

        public int nowPageNum = 0; //阅读页码

        public int NowPageNum
        {
            get { return nowPageNum; }
            set { nowPageNum = value; }
        }


        public int maxPageNum = 0; //最大页数

        public int MaxPageNum
        {
            get { return maxPageNum; }
            set { maxPageNum = value; }
        }

        public Marker(String BookName, String url, double percent, String preview, String time)
        {
            this.bookName = BookName;
            this.url = url;
            this.percent = percent;
            this.preview = preview;
            this.time = time;
        }
        public Marker()
        {

        }

        //缓存的书签列表
        public static List<Marker> markers = null;

        //获取设置
        public static List<Marker> get()
        {
            if (markers == null)
            {
                markers = LoadXmlService.getObj<Marker>();
            }
            return markers;
        }

        public static int save()
        {
            return LoadXmlService.saveObj(get());
        }

        public static int save(List<Marker> m)
        {
            markers = m;
            return save();
        }
    }
}
