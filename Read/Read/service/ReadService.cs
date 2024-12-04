
using Read.form;
using Read.model;
using Reader.model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reader.services
{
    public class ReadService
    {
        public static int preReadingNum = 60;//前后预读页数

        public static float tboxWidth = 0;//主界面文本显示框宽度

        public static int CNCount = 0; //每行中文最大字数

        public static Font font = null;//主页面文本显示字体

        public static float fontWidth = 0;

        /// <summary>
        /// 初始化分割字符串所需参数
        /// </summary>
        public static void initParams()
        {
            fontWidth = Common.toPx(Setting.get().FontSize);
            tboxWidth = ReadCache.readTboxWidth - fontWidth;  //书籍显示文本框最大显示宽度
            font = new Font(Setting.get().FontStyle, Setting.get().FontSize);
            CNCount = (int)(tboxWidth / fontWidth);//计算每行最大容纳中文字数
        }

        /// <summary>
        /// 创建一个图像对象，用以计算文字宽度
        /// </summary>
        /// <returns></returns>
        public static Graphics getGraphics()
        {
            Graphics grap = new BaseForm().CreateGraphics();
            grap.PageUnit = GraphicsUnit.Pixel;
            return grap;
        }


        /// <summary>
        /// 获取文本宽度
        /// </summary>
        /// <param name="s"></param>
        /// <param name="grap"></param>
        /// <returns></returns>
        public static float getWidth(String s, Graphics grap)
        {
            if (s.Contains("　"))
                s = Regex.Replace(s, "　", "正");//中文空格替换为正字计算宽度
            if (s.Contains(" "))
                s = Regex.Replace(s, " ", "a");//英文空格替换为a计算宽度
            return grap.MeasureString(s, font, 50000, StringFormat.GenericTypographic).Width;
        }

        /// <summary>
        /// 根据字符宽度分割字符串条数
        /// </summary>
        /// <param name="s"></param>
        /// <param name="grap"></param>
        /// <returns></returns>
        public static int getCount(String s, Graphics grap)
        {
            return Common.isBlank(s) || s.Length <= CNCount ? 1 : (int)Math.Ceiling(getWidth(s, grap) / tboxWidth);
        }

        /// <summary>
        /// 根据字符宽度分割字符串
        /// </summary>
        /// <param name="s"></param>
        /// <param name="grap"></param>
        /// <returns></returns>
        public static List<String> splitStr(String s, Graphics grap)
        {
            int count = getCount(s, grap);
            List<String> list = new List<String>(count);
            if (Common.isBlank(s) || count == 1)
            {
                list.Add(s);
            }
            else
            {
                StringBuilder sb = new StringBuilder();
                char[] chars = s.ToCharArray();
                for (int i = 0; i < chars.Count(); i++)
                {
                    char c = chars[i];
                    //集合只剩一个元素时直接一次性将所有剩余字符转为string
                    if (list.Count == count - 1)
                    {
                        int surplus = chars.Count() - i; //剩余字符长度
                        char[] z = new char[surplus];
                        Array.ConstrainedCopy(chars, i, z, 0, surplus);
                        list.Add(Regex.Replace(sb.Append(z).ToString(), @"\s", ""));
                        return list;
                    }
                    //如果字符宽度小于文本框宽度
                    if (getWidth(sb.ToString() + c.ToString(), grap) <= tboxWidth)
                    {
                        sb.Append(c);
                    }
                    else
                    {
                        list.Add(sb.ToString());
                        sb.Clear().Append(c);
                    }
                }
                if (sb.Length > 0)
                {
                    list.Add(sb.ToString());
                }
            }
            if (list.Count < count)
            {
                //如果实际分行少于理想分行  则补一条空白行
                for (int i = 0; i < count - list.Count; i++)
                {
                    list.Add("  test");
                }
            }
            return list;
        }


        /// <summary>
        /// 读取书籍
        /// </summary>
        /// <param name="getMaxNum"></param>
        /// <returns></returns>
        public static Dictionary<int, string> ReadBook(bool getMaxNum)
        {
            Dictionary<int, string> map = new Dictionary<int, string>();
            String url = ReadCache.bookUrl;             //书籍路径
            if (!Common.isExist(url)) return map;
            int pageNum = ReadCache.nowPageNum;         //当前页码
            int lineSize = ReadCache.lineSize;     //每页行数
            initParams();                               //初始化分割字符串所需参数
            int lineCount = 0;                          //读取文本页数
            Graphics grap = getGraphics();//创建一个图像对象，用以计算文字宽度

            /**前后预读*/
            int pageLineStart = (pageNum - 1 - preReadingNum) * lineSize + 1;//开始行
            int pageLineEnd = (pageNum + preReadingNum) * lineSize;//结束行
            using (StreamReader sr = new StreamReader(url, EncodingType.GetType(url)))
            {
                String line;
                while ((line = sr.ReadLine()) != null)
                {
                    int splitCount = getCount(line, grap);//获取当前行分割后行数
                    if (regionJudge(lineCount, lineCount + splitCount, pageLineStart, pageLineEnd))
                    {
                        List<String> list = splitStr(line, grap);
                        for (int i = 0; i < list.Count; i++)
                        {
                            map.Add(++lineCount, list[i]);
                        }
                    }
                    else
                    {
                        lineCount += splitCount;
                    }
                    if (lineCount >= pageLineEnd && !getMaxNum)
                    {
                        break; //如果行数大于当前页最后一行 结束循环以提升效率
                    }
                }
                if (getMaxNum)
                {
                    //计算最大页数
                    ReadCache.maxPageNum = Common.divideCeiling(lineCount, lineSize);
                    //扫描目录
                    Chapter.init();
                }
                sr.Close();
            }
            return map;
        }



        /// <summary>
        /// 扫描书签 单条件、模糊扫描、双章节扫描
        /// </summary>
        /// <returns></returns>
        public static List<Chapter> getChapters()
        {
            Graphics grap = getGraphics();
            List<Chapter> result = new List<Chapter>();
            String url = ReadCache.bookUrl;         //书籍路径
            if (!Common.isExist(url)) return result;
            int maxCount = ReadCache.maxPageNum;    //最大页数
            int lineSize = ReadCache.lineSize; //每页行数
            initParams();//初始化分割字符串所需参数
            //   String rule = Setting.get().Rule;       //章节规则
            //  String rule = "章篇集节卷回部";
            //    if (Common.isBlank(rule)) return result;
            int num = 0;
            Regex r = new Regex("^第?[一二两三四五六七八九十零千百0123456789]{1,8}[章篇集节卷回部]{1,1}([ -:：；;]+.{0,30}|$)");
            using (StreamReader sr = new StreamReader(url, EncodingType.GetType(url)))
            {
                String line;
                int no = 0;
                while ((line = sr.ReadLine()) != null)
                {
                    num += getCount(line, grap);
                    foreach (Match mch in r.Matches(line.Trim()))
                    {
                        if (maxCount > 0 && lineSize > 0)
                        {
                            // string[] strs = new Regex(rule).Split(mch.Value);
                            int count = Common.divideCeiling(num, lineSize);
                            result.Add(new Chapter(++no, mch.Value, Convert.ToDecimal(count * 100.00 / maxCount), count));
                        }

                    }
                }
            }
            return result;
        }



        /// <summary>
        /// 区间判断
        /// </summary>
        /// <param name="a1"></param>
        /// <param name="a2"></param>
        /// <param name="b1"></param>
        /// <param name="b2"></param>
        /// <returns></returns>
        public static Boolean regionJudge(int a1, int a2, int b1, int b2)
        {
            if (a1 > b2 || a2 < b1) return false;
            for (int i = a1; i <= a2; i++)
            {
                if (i >= b1 && i <= b2)
                {
                    return true;//有重叠
                }
            }
            return false;//无重叠
        }


        /// <summary>
        ///  获取书籍最大页数
        /// </summary>
        /// <returns></returns>
        public static int getMaxCount()
        {
            Graphics grap = getGraphics();
            int num = 0;
            String url = ReadCache.bookUrl;
            if (!Common.isExist(url)) return num;
            int lineCount = ReadCache.lineSize;
            initParams();//初始化分割字符串所需参数
            using (StreamReader sr = new StreamReader(url, EncodingType.GetType(url)))
            {
                String line;
                while ((line = sr.ReadLine()) != null)
                {
                    //判断是不是最后一页
                    num += getCount(line, grap);
                }
            }
            return Common.divideCeiling(num, lineCount);
        }


        /// <summary>
        /// 以指定字符为中心截取一段字符串
        /// </summary>
        /// <param name="parentStr"></param>
        /// <param name="str"></param>
        /// <param name="len"></param>
        /// <returns></returns>
        public static String subCenterStr(String parentStr, String str, int len)
        {
            if (parentStr.Length > len)
            {
                String returnStr = parentStr;
                int otherLen = (len - str.Length) / 2;
                int index = parentStr.IndexOf(str);
                if (index + str.Length + otherLen > parentStr.Length)
                {
                    return parentStr.Substring(parentStr.Length - len);
                }
                else
                {
                    if (index >= otherLen)
                    {
                        returnStr = parentStr.Substring(index - otherLen);
                    }
                    if (returnStr.Length > len)
                    {
                        returnStr = returnStr.Substring(0, len);
                    }
                }
                return returnStr;
            }
            return parentStr;
        }

        /// <summary>
        /// 全文检索
        /// </summary>
        /// <param name="str"></param>
        /// <param name="maxCount"></param>
        /// <returns></returns>
        public static List<SearchResult> fullSearch(String str, int lineLength, int maxCount)
        {
            Graphics grap = getGraphics();
            List<SearchResult> list = new List<SearchResult>();
            String url = ReadCache.bookUrl;
            if (!Common.isExist(url)) return list;
            int lineCount = ReadCache.lineSize;
            initParams();//初始化分割字符串所需参数
            List<Chapter> chapters = Chapter.get();

            int num = 0;
            using (StreamReader sr = new StreamReader(url, EncodingType.GetType(url)))
            {
                String line;
                while ((line = sr.ReadLine()) != null)
                {
                    if (line.Contains(str))
                    {
                        SearchResult result = new SearchResult();
                        int temp = Common.divideCeiling(num, lineCount);
                        result.PageNum = temp;
                        result.Preview = subCenterStr(line.Trim(), str, lineLength);
                        if (chapters != null)
                        {
                            for (int i = 0; i < chapters.Count; i++)
                            {
                                //所属章节判断有点误差 当跨越两页时 默认判断归属为下一章节
                                int nowNum = chapters[i].PageNum;
                                int nextNum = i + 1 < chapters.Count ? chapters[i + 1].PageNum : ReadCache.maxPageNum + 1;
                                if (result.PageNum >= nowNum && result.PageNum < nextNum)
                                {
                                    result.Chapter = chapters[i].catalogName;
                                    break;
                                }
                            }
                        }
                        list.Add(result);
                        if (maxCount != 0 && list.Count >= maxCount)
                        {
                            return list;
                        }
                    }
                    num += getCount(line, grap);
                }
            }
            return list;
        }


        /// <summary>
        /// 查找指定段落在书籍中的页码位置
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static int appointNum(String str)
        {
            Graphics grap = getGraphics();
            String url = ReadCache.bookUrl;
            if (!Common.isExist(url)) return 0;
            int lineCount = ReadCache.lineSize;
            initParams();//初始化分割字符串所需参数
            int num = 0;
            using (StreamReader sr = new StreamReader(url, EncodingType.GetType(url)))
            {
                String line;
                while ((line = sr.ReadLine()) != null)
                {
                    if (line.Contains(str))
                    {
                        return Common.divideCeiling(num, lineCount);
                    }
                    num += getCount(line, grap);
                }
            }
            return num;
        }


        /// <summary>
        /// 递归扫描文件夹下的书籍（调用）
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        public static List<Book> scanningFolder(String url)
        {
            if (Directory.Exists(url))
            {
                return scanningFolder(url, new List<Book>());
            }
            return new List<Book>();
        }


        /// <summary>
        /// 递归扫描文件夹下的书籍
        /// </summary>
        /// <param name="url"></param>
        /// <param name="list"></param>
        /// <returns></returns>
        public static List<Book> scanningFolder(String url, List<Book> list)
        {
            DirectoryInfo Di = new DirectoryInfo(url);
            try
            {
                FileSystemInfo[] Fsi = Di.GetFileSystemInfos();
                for (int i = 0; i < Fsi.Length; i++)
                {
                    String path = "";
                    List<Book> child = new List<Book>();
                    if (Fsi[i] is DirectoryInfo)//是文件夹
                    {
                        path = (Fsi[i] as DirectoryInfo).FullName;
                        child = scanningFolder(path, child);
                    }
                    if (Fsi[i] is FileInfo)//是文件
                    {
                        FileInfo file = new FileInfo(Fsi[i].FullName);
                        if (!file.Extension.Equals(".txt")) continue;
                        String name = file.Name.Replace(".txt", "");//文件名
                        String length = Common.CountSize(file.Length);//大小
                        path = Fsi[i].FullName.Replace("\\", "/");//路径

                        list.Add(new Book(path, name, length));
                    }
                    list.AddRange(child);
                }
            }
            catch (Exception)
            {
                //没有权限的文件夹不做任何操作
            }
            return list;
        }

    }
}
