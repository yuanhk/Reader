using Read.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Read.service
{
    public class HotKeyService
    {
        private static String[] Irregular = new String[] { "ControlKey", "Menu", "LWin", "RWin" };

        /// <summary>
        /// 是否已存在
        /// </summary>
        /// <param name="keyCode"></param>
        /// <returns></returns>
        public static bool exists(String keyCode)
        {
            return HotKey.get().Exists(t => keyCode.Equals(t.KeyCode)) || Irregular.Contains(keyCode);
        }

        public static String details(String keyCode)
        {
            Dictionary<string, string> map = HotKey.getKeyCodeMap();
            return map.ContainsKey(keyCode) ? map[keyCode] : "";
        }
    }
}
