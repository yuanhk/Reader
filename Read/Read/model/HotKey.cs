using Read.service;
using Reader.model;
using Reader.services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Read.model
{
    public class HotKey
    {
        private String keyCode;

        public String KeyCode
        {
            get { return keyCode; }
            set { keyCode = value; }
        }
        private String effect;

        public String Effect
        {
            get { return effect; }
            set { effect = value; }
        }
        private String details;

        public String Details
        {
            get { return details; }
            set { details = value; }
        }

        private static List<HotKey> hotKeyList = null;

        public static int save()
        {
            return LoadXmlService.saveObj(get());
        }
        public static int save(List<HotKey> hotkeys)
        {
            hotKeyList = hotkeys;
            return save();
        }

        /// <summary>
        /// 获取 如果从配置文件中获取不到则重置
        /// </summary>
        /// <returns></returns>
        public static List<HotKey> get()
        {
            if (hotKeyList == null || hotKeyList.Count == 0)
            {
                List<HotKey> temp = LoadXmlService.getObj<HotKey>();
                hotKeyList = temp.Count == 0 ? reset() : temp;
            }
            return hotKeyList;
        }


        //根据编号获取按键码
        public static String getKeyCode(int index)
        {
            if (hotKeyList != null && hotKeyList.Count > index)
            {
                return hotKeyList[index].KeyCode;
            }
            return "";
        }

        public static bool updateKeyCode(int index, String code)
        {
            if (hotKeyList != null && hotKeyList.Count > index)
            {
                hotKeyList[index].KeyCode = code;
                hotKeyList[index].Details = HotKeyService.details(code);
                return save() > 0;
            }
            return false;
        }

        /// <summary>
        /// 获取按键码详情
        /// </summary>
        private static Dictionary<string, string> keyCodeMap = null;
        public static Dictionary<string, string> getKeyCodeMap()
        {
            if (keyCodeMap == null)
                keyCodeMap = LoadXmlService.getMaps("KeyCodes");
            return keyCodeMap;
        }

        /// <summary>
        /// 重置热键设置
        /// </summary>
        /// <returns></returns>
        public static List<HotKey> reset()
        {
            hotKeyList = LoadXmlService.getDefault<HotKey>();
            return hotKeyList;
        }




        //public static List<HotKeyShow> get()
        //{
        //    if (list == null)
        //    {
        //        list = new List<HotKeyShow>();
        //        Dictionary<string, string> map = LoadXmlService.getMaps("HotKeys");
        //        Dictionary<string, string> contrast = LoadXmlService.getMaps("KeyCodes");
        //        HotKey keys = HotKey.get();
        //        Type t = keys.GetType();
        //        PropertyInfo[] PropertyList = t.GetProperties();
        //        foreach (PropertyInfo item in PropertyList)
        //        {
        //            string name = item.Name;
        //            object value = item.GetValue(keys, null);
        //            if (map.ContainsKey(name))
        //            {
        //                HotKeyShow temp = new HotKeyShow();
        //                temp.keyCode = map[name];
        //                String effect = Common.toString(value);
        //                temp.effect = effect;
        //                temp.details = contrast[effect];
        //                list.Add(temp);
        //            }
        //        }
        //    }
        //    return list;
        //}

    }
}
