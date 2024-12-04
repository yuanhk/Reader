using Read.model;
using Reader.services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reader.model
{
    public class Chapter
    {
        public int catalogNo;
        public String catalogName;
        public String percentText;
        public int pageNum;
        public decimal percent;

        //public decimal Percent
        //{
        //    get { return percent; }
        //    set { percent = value; }
        //}


       

        public int CatalogNo
        {
            get { return catalogNo; }
            set { catalogNo = value; }
        }


        public String CatalogName
        {
            get { return catalogName; }
            set { catalogName = value; }
        }



        public String PercentText
        {
            get { return percentText; }
            set { percentText = value; }
        }


        public int PageNum
        {
            get { return pageNum; }
            set { pageNum = value; }
        }
        public Chapter()
        {
        }
        public Chapter(int catalogNo, String catalogName, decimal percent, int num)
        {
            this.catalogNo = catalogNo;
            this.catalogName = catalogName;
            this.PercentText = Math.Round(percent, 2).ToString("f2") + "%";
            this.percent = Math.Round(percent, 2);
            this.pageNum = num;
        }

        private static List<Chapter> chapters = null;

        public static List<Chapter> get()
        {
            //chapters: null 获取一次，0 不做操作 0+ 返回数据 
            if (chapters == null)
            {
                chapters = ReadService.getChapters();
            }
            return chapters;
        }

        //重新遍历获取章节目录
        public static void init()
        {
            chapters = ReadService.getChapters();
        }
    }
}
