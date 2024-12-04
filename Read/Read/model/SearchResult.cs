using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Read.model
{
    /// <summary>
    /// 全文查找结果
    /// </summary>
    public class SearchResult
    {
        private String preview;

        public String Preview
        {
            get { return preview; }
            set { preview = value; }
        }
        private int pageNum;

        public int PageNum
        {
            get { return pageNum; }
            set { pageNum = value; }
        }
        private String chapter;

        public String Chapter
        {
            get { return chapter; }
            set { chapter = value; }
        }


        private static List<SearchResult> results = null;

        public static List<SearchResult> get()
        {
            if (results == null )
            {
                return new List<SearchResult>();
            }
            return results;
        }

        public static void set(List<SearchResult> data) {
            results = data;
        }
    }
}
