using Reader.services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reader.model
{
    public class ReadCache
    {
        public static String bookName = "";//书籍名
        public static String bookUrl = ""; //文本路径
        public static int maxPageNum = 0; //最大页数
        public static int nowPageNum = 1;//当前页数
        public static Decimal readPercent = 0;//阅读百分比
        public static int lineSize = 0;//每页最大显示行数
        public static int readTboxWidth = 0; //书籍显示文本框宽度
        //MainForm
        public static int catalogNum = 0; //书籍目录序号
        public static Dictionary<int, String> pageList;//书页缓存

  
        /// <summary>
        /// 覆盖
        /// </summary>
        /// <param name="b"></param>
        /// <param name="r"></param>
        /// <param name="percentage"></param>
        public static void newReadCache(Book b, RichTextBox r, String percentage)
        {
            bookName = b.Name;
            bookUrl = b.Url;
            //计算每页最大显示行数
            calcLineSize(r);
            //计算总页数
            maxPageNum = ReadService.getMaxCount();
            //计算当前页数   
            //第三种构思：上次阅读记录保存上次阅读第一行文本  重新加载时全文检索配合阅读进度获取当前阅读页数  因较复杂且可能影响效率 故搁置
            if ( b.MaxPageNum == maxPageNum && b.NowPageNum != 0)
                nowPageNum = b.NowPageNum;
            else if (Common.notBlank(percentage))
                calcNowPageNum(percentage);
            else
                nowPageNum = 1;
        }

        /// <summary>
        /// 计算每页最大显示行数
        /// </summary>
        /// <param name="r"></param>
        private static void calcLineSize(RichTextBox r)
        {
            r.Hide();
            r.Text = "1\n2\n";
            //第一行第一个字节的坐标
            System.Drawing.Point ptLine1 = r.GetPositionFromCharIndex(r.GetFirstCharIndexFromLine(0));
            //第二行第一个字节的坐标
            System.Drawing.Point ptLine2 = r.GetPositionFromCharIndex(r.GetFirstCharIndexFromLine(1));
            lineSize = r.Height / (ptLine2.Y - ptLine1.Y);
            readTboxWidth = r.Width;
        }


        /// <summary>
        /// 根据阅读进度计算当前阅读页码
        /// </summary>
        /// <param name="percentage"></param>
        public static void calcNowPageNum(String percentage)
        {
            decimal d = decimal.Parse(percentage);
            int num = (int)Math.Floor(decimal.Round(d * ReadCache.maxPageNum / 100, 1));
            nowPageNum = num == 0 ? 1 : num;
        }


        public ReadCache()
        {
        }
    }
}
