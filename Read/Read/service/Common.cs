using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing;
using System.Diagnostics;
namespace Reader.services
{
    /**
     * 通用工具类 
     */
    public class Common : NativeWindow
    {

        public static Keys toKeys(String s)
        {
            Keys k;
            Enum.TryParse<Keys>(s, out k);
            return k;
        }

        //获取配置文件夹路径
        public static String getCfgUrl()
        {
            // return System.IO.Directory.GetCurrentDirectory() + "\\config";
            return "D:\\test\\read\\config";
        }
        //获取程序文件夹路径
        public static String getSystemUrl()
        {
           // return System.IO.Directory.GetCurrentDirectory() + "\\books";
            return "D:\test\read\book";
        }

        //判断文件是否存在
        public static bool isExist(String url)
        {
            return url != null && url.Length > 0 && File.Exists(url);
        }

        //相除且进一
        public static int divideCeiling(Object a, Object b)
        {
            if (a != null && b != null)
            {
                decimal num1; //定义两个数字类型
                decimal num2;
                if (Decimal.TryParse(a.ToString(), out num1) && Decimal.TryParse(b.ToString(), out num2))
                {
                    return (int)Math.Ceiling(num1 / num2);
                }

            }
            return -1;
        }

        //转为字符串
        public static string toString(Object obj)
        {
            if (obj == null) return "";
            return obj.ToString();
        }

        //转为字符串
        public static string toString(Object obj, String defaultStr)
        {
            if (obj == null) return defaultStr;
            return obj.ToString();
        }

        //判断字符串为空
        public static bool isBlank(String str)
        {
            return str == null || str.Length == 0;
        }

        //判断字符串不为空
        public static bool notBlank(String str)
        {
            return str != null && str.Length > 0;
        }

        //首字母大写
        public String ToTitleCase(String str)
        {
            if (str != null && str.Length > 0)
            {
                char[] cs = str.ToCharArray();
                cs[0] = Char.ToUpper(cs[0]);
                return cs.ToString();
            }
            return str;
        }


        public static string getSize(String url)
        {
            if (Common.notBlank(url))
            {
                FileInfo f = new FileInfo(url);
                if (f.Exists)
                    return CountSize(f.Length);
            }
            return "0B";
        }

        //储存大小格式转换
        public static string CountSize(long Size)
        {
            string m_strSize = "";
            long FactSize = 0;
            FactSize = Size;
            if (FactSize < 1024.00)
                m_strSize = FactSize.ToString("F2") + " B";
            else if (FactSize >= 1024.00 && FactSize < 1048576)
                m_strSize = (FactSize / 1024.00).ToString("F2") + " KB";
            else if (FactSize >= 1048576 && FactSize < 1073741824)
                m_strSize = (FactSize / 1024.00 / 1024.00).ToString("F2") + " MB";
            else if (FactSize >= 1073741824)
                m_strSize = (FactSize / 1024.00 / 1024.00 / 1024.00).ToString("F2") + " GB";
            return m_strSize;
        }

        //日志记录
        public static void saveLog(String errorMsg)
        {
            String path = getCfgUrl() + "/ErrorLog.log";
            DateTime dt = DateTime.Now;
            string str = dt.ToString("yyyy-MM-dd HH:mm:ss");
            if (!File.Exists(path))
            {
                string createText = str + " | 创建日志文件" + Environment.NewLine;
                File.WriteAllText(path, createText);
            }
            string appendText = str + " | " + errorMsg + Environment.NewLine;
            File.AppendAllText(path, appendText);
            File.ReadAllText(path);
        }

        //px转pt
        public static float toPt(int px)
        {
            float[] pts = { 5, 5.5f, 6.5f, 7, 7.5f, 8, 9, 10, 10.5f, 11, 12, 13, 13.5f, 14, 14.5f };
            return px >= 6 && px <= 20 ? pts[px - 6] : -1;
        }

        //pt转px
        public static int toPx(double pt)
        {
          
            Double[] items = { 5, 5.5, 6.5, 7, 7.5, 8, 9, 10, 10.5, 11, 12, 13, 13.5, 14, 14.5 };
              List<double> pts = items.ToList<double>();
            return pts.IndexOf(pt) == -1 ? -1 : pts.IndexOf(pt) + 6;
        }


        public static int toInt(Object obj)
        {
            return toInt(toString(obj), 0);
        }

        public static int toInt(String s, int i)
        {
            int intStrNum = 0;
            if (int.TryParse(s, out intStrNum))
            {
                return intStrNum;
            }
            return i;
        }


        //隐藏listView 水平滚动条
        public static void setAssignHandle(IntPtr Handle)
        {
            new Common().AssignHandle(Handle);
        }


        /// <summary>
        /// 打开路径并定位文件...对于@"h:\Bleacher Report - Hardaway with the safe call ??.mp4"这样的，explorer.exe /select,d:xxx不认，用API整它
        /// </summary>
        /// <param name="filePath">文件绝对路径</param>
        [DllImport("shell32.dll", ExactSpelling = true)]
        private static extern void ILFree(IntPtr pidlList);

        [DllImport("shell32.dll", CharSet = CharSet.Unicode, ExactSpelling = true)]
        private static extern IntPtr ILCreateFromPathW(string pszPath);

        [DllImport("shell32.dll", ExactSpelling = true)]
        private static extern int SHOpenFolderAndSelectItems(IntPtr pidlList, uint cild, IntPtr children, uint dwFlags);

        public static void ExplorerFile(string filePath)
        {
            if (!File.Exists(filePath) && !Directory.Exists(filePath))
                return;

            if (Directory.Exists(filePath))
                Process.Start(@"explorer.exe", "/select,\"" + filePath + "\"");
            else
            {
                IntPtr pidlList = ILCreateFromPathW(filePath);
                if (pidlList != IntPtr.Zero)
                {
                    try
                    {
                        Marshal.ThrowExceptionForHR(SHOpenFolderAndSelectItems(pidlList, 0, IntPtr.Zero, 0));
                    }
                    finally
                    {
                        ILFree(pidlList);
                    }
                }
            }
        }

    }
}
