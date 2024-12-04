using Reader.services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reader.model
{
    public class Book
    {
        public String url;             //书籍路径

        public String Url
        {
            get { return url; }
            set { url = value; }
        }
        public String name;            //书籍名称

        public String partUrl;         //局部书籍路径

        public String PartUrl
        {
            get { return partUrl; }
            set { partUrl = value; }
        }


        public String Name
        {
            get { return name; }
            set { name = value; }
        }
        public String size = "";       //书籍大小

        public String Size
        {
            get { return size; }
            set { size = value; }
        }
        public Decimal readPercent;     //已阅读百分比

        public String percentStr; //百分比显示

        public String PercentStr
        {
            get
            {
                return Math.Round(readPercent, 2) + "%";
            }
            set { percentStr = value; }
        }

        public Decimal ReadPercent
        {
            get { return readPercent; }
            set { readPercent = value; }
        }
        public String lastReadTime;    //最后阅读时间

        public String LastReadTime
        {
            get { return lastReadTime; }
            set { lastReadTime = value; }
        }
        public String chapter;

        public String Chapter
        {
            get { return chapter; }
            set { chapter = value; }
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



        public Book()
        {

        }
        public Book(String url, String name, String size)
        {
            this.url = url;
            this.name = name;
            this.size = size;
        }


        private static List<Book> bookList = null;

        //判断书籍是否在书架列表里
        public static bool isExist(String url)
        {

            if (bookList != null && bookList.Count > 0)
            {
                foreach (Book b in bookList)
                {
                    if (b.Equals(url))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        //新增或编辑一条
        public static void save(Book b)
        {
            bookList = get();
            for (int i = 0; i < bookList.Count; i++)
            {
                if (bookList[i].Url.Equals(b.Url))
                {
                    bookList.RemoveAt(i);
                    break;
                }
            }
            bookList.Insert(0, b);
            save();
        }

        /// <summary>
        /// 获取
        /// </summary>
        /// <returns></returns>
        public static List<Book> get()
        {
            if (bookList == null)
            {
                bookList = LoadXmlService.getObj<Book>();
            }
            return bookList;
        }

        /// <summary>
        /// 保存
        /// </summary>
        public static int save()
        {
            return LoadXmlService.saveObj(get());
        }

        /// <summary>
        /// 追加多条
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public static int append(List<Book> books)
        {
            if (books != null)
            {
                books.AddRange(bookList);
                bookList = books;
                return save();
            }
            return 0;
        }

        /// <summary>
        /// 保存书籍列表
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public static int save(List<Book> list)
        {
            bookList = list;
            return save();
        }
    }
}
