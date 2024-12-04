using Read.model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Reader.services
{
    public class LoadXmlService
    {

        public static String settingFileName = "\\Settings.xml";//系统设置文件名称
        public static String[] filterField = new String[] { "PartUrl", "PreviewStr" };//写入XML文件时需要过滤的字段


        /// <summary>
        /// 检查修复配置文件
        /// </summary>
        public static void repairXml()
        {
            String cfgurl = Common.getCfgUrl();
            //无则创建文件夹
            if (!Directory.Exists(cfgurl)) Directory.CreateDirectory(cfgurl);
            //无则创建配置文件
            String xmlUrl = cfgurl + settingFileName;
            if (!File.Exists(xmlUrl)) File.Create(xmlUrl).Close();
            XmlDocument doc = new XmlDocument();
            try
            {
                doc.Load(xmlUrl);
            }
            catch (Exception)
            {
                doc.RemoveAll();
                doc.AppendChild(doc.CreateXmlDeclaration("1.0", "UTF-8", null));
                XmlElement root = doc.CreateElement("Configuration");
                root.InnerText = "";
                doc.AppendChild(root);
                doc.Save(xmlUrl);
                Common.saveLog("初始化配置文件");
            }
            XmlElement baseNode = doc.DocumentElement;
            String[] nodes = { "Book", "Marker", "Setting", "HotKey" };
            foreach (String node in nodes)
            {
                if (baseNode.SelectSingleNode(node) == null)
                {
                    XmlElement book = doc.CreateElement(node);
                    book.InnerText = "";
                    baseNode.AppendChild(book);
                }
            }
            doc.Save(xmlUrl);
        }



        /// <summary>
        /// 读取xml文件并转换为对象集合
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static List<T> getObj<T>() where T : new()
        {
            repairXml();
            String xmlUrl = Common.getCfgUrl() + settingFileName;
            if (File.Exists(xmlUrl))
            {
                try
                {
                    XmlDocument doc = new XmlDocument();
                    doc.Load(xmlUrl);
                    XmlNodeList childList = doc.SelectSingleNode("//" + new T().GetType().Name).ChildNodes;
                    return toList<T>(childList);
                }
                catch (Exception e)
                {
                    Common.saveLog("解析xml异常！" + e.Message);
                    System.Windows.Forms.MessageBox.Show("解析xml异常！" + e.Message);
                }
            }
            return new List<T>();
        }


        /// <summary>
        /// XmlNodeList转list
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="childList"></param>
        /// <returns></returns>
        public static List<T> toList<T>(XmlNodeList childList) where T : new()
        {
            List<T> list = new List<T>();
            foreach (XmlNode xn in childList)
            {
                var md = new T();
                if (Common.isBlank(xn.InnerText)) continue;
                foreach (XmlNode field in xn.ChildNodes)
                {
                    PropertyInfo info = md.GetType().GetProperty(field.Name);
                    if (info != null) info.SetValue(md, Convert.ChangeType(field.InnerText, info.PropertyType));
                }
                list.Add(md);
            }
            return list;
        }



        /// <summary>
        /// XmlNodeList转map
        /// </summary>
        /// <param name="childList"></param>
        /// <returns></returns>
        public static Dictionary<string, string> toMap(XmlNodeList childList)
        {
            Dictionary<string, string> map = new Dictionary<string, string>();
            foreach (XmlNode xn in childList)
            {
                if (Common.isBlank(xn.InnerText)) continue;
                String key = null;
                String value = null;
                foreach (XmlNode field in xn.ChildNodes)
                {
                    if ("Key".Equals(field.Name))
                    {
                        key = field.InnerText;
                    }
                    else if ("Value".Equals(field.Name))
                    {
                        value = field.InnerText;
                    }
                    if (Common.notBlank(key) && Common.notBlank(value))
                    {
                        map.Add(key, value);
                    }
                }
            }
            return map;
        }


        /// <summary>
        /// 从xml文件中获取默认设置
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static List<T> getDefault<T>() where T : new()
        {
            String fileName = "Default" + new T().GetType().Name;
            try
            {
                ResourceManager rm = new ResourceManager("Read.Properties.Resources", Assembly.GetEntryAssembly());
                Object obj = rm.GetObject(fileName);
                if (obj != null)
                {
                    XmlDocument doc = new XmlDocument();
                    doc.LoadXml(obj.ToString());
                    return toList<T>(doc.ChildNodes[2].ChildNodes);
                }
            }
            catch (Exception e)
            {
                Common.saveLog("从Xml中获取默认设置失败！文件名:" + fileName + ";" + e.Message);
            }
            return new List<T>();
        }


        /// <summary>
        /// 将对象集合写入xml
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        /// <returns></returns>
        public static int saveObj<T>(List<T> list) where T : new()
        {
            if (list == null)
                return 0;
            repairXml();
            Type type = new T().GetType();
            String xmlUrl = Common.getCfgUrl() + settingFileName;
            if (File.Exists(xmlUrl))
            {
                try
                {
                    XmlDocument doc = new XmlDocument();
                    doc.Load(xmlUrl);
                    XmlNode xn = doc.SelectSingleNode("//" + new T().GetType().Name);
                    xn.RemoveAll();
                    for (int i = 0; i < list.Count; i++)
                    {
                        XmlElement node = doc.CreateElement("item");
                        foreach (PropertyInfo pi in type.GetProperties())
                        {
                            if (!filterField.Contains(pi.Name))
                            {
                                object value = pi.GetValue(list[i], null);//用pi.GetValue获得值
                                XmlElement element = doc.CreateElement(pi.Name);
                                element.InnerText = Convert.ToString(value);
                                node.AppendChild(element);
                            }
                        }
                        xn.AppendChild(node);
                        XmlElement node2 = doc.CreateElement("item");
                    }
                    doc.Save(Common.getCfgUrl() + settingFileName);
                    return list.Count;
                }
                catch (Exception e)
                {
                    Common.saveLog("写入xml异常！" + e.Message);
                    System.Windows.Forms.MessageBox.Show("写入xml异常！" + e.Message);
                }
            }
            return 0;
        }



        /// <summary>
        /// 从Xml中获取数据并转为Map
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public static Dictionary<string, string> getMaps(String fileName)
        {
            Dictionary<string, string> map = new Dictionary<string, string>();
            ResourceManager rm = new ResourceManager("Read.Properties.Resources", Assembly.GetEntryAssembly());
            Object obj = rm.GetObject(fileName);
            if (obj == null) return map;
            try
            {
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(obj.ToString());
                XmlNodeList childList = doc.SelectSingleNode(fileName).ChildNodes;
                return toMap(childList);
            }
            catch (Exception e)
            {
                Common.saveLog("从Xml中获取数据并转为Map异常！文件名:" + fileName + ";" + e.Message);
            }
            return map;
        }

    }
}
