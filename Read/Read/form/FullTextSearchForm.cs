using Read.model;
using Read.service;
using Reader.model;
using Reader.services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Read.form
{
    public partial class FullTextSearchForm : BaseForm
    {
        public event MainForm.TransfDelegate TransfEvent;
        public event MainForm.highlight highlight;
        public static String sreachTerm = "";        //全文检索条件缓存

        //全文检索结果
        public List<SearchResult> fullSearchList = null;

        public FullTextSearchForm()
        {
            InitializeComponent();
        }

        private void Mainsdasd_Load(object sender, EventArgs e)
        {
            UnderscoreBox.BackColor = BaseForm.foreColor;
            titleBox.Text = "全文查找";


            sreachText.LostFocus += new EventHandler(txt_LostFocus); //失去焦点后发生事件
            //搜索文本框限制最大字数
            sreachText.ForeColor = foreColor;
            sreachText.BackColor = backColor;

            if (Common.notBlank(sreachTerm))
            {
                sreachText.Text = sreachTerm;
                fullSearchList = SearchResult.get();
                setData();
            }
            scapegoat.Focus();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            fullTextSearch();
        }

        private void setData()
        {
            fullSearchDgv.DataSource = new BindingList<SearchResult>(fullSearchList);
            statisticsTB.Text = "共计：" + fullSearchList.Count + " 条";
        }

        private void fullTextSearch()
        {
            sreachTerm = sreachText.Text;
            if (Common.isBlank(sreachText.Text))
            {
                fullSearchList = new List<SearchResult>();
                showMessage("未检索到该文本");
                setData();
                return;
            }
            this.DoWorkAsync((o) =>
            {
                fullSearchList = ReadService.fullSearch(sreachTerm, 33, 0);
                return null;
            }, null, (r) =>
            {
                SearchResult.set(fullSearchList);
                setData();
                showMessage(fullSearchList.Count == 0 ? "未检索到该文本" : "全文检索成功");
            });
        }

        private void fullSearchDgv_DoubleClick(object sender, EventArgs e)
        {
            if (fullSearchDgv.SelectedRows.Count > 0)
            {
                int nowPageNum = (int)fullSearchDgv.SelectedRows[0].Cells[1].Value;
                if (nowPageNum > 0)
                {
                    ReadCache.nowPageNum = nowPageNum;
                    this.DoWorkAsync((o) =>
                    {
                        Dictionary<int, String> value = ReadService.ReadBook(false);
                        TransfEvent(value);
                        highlight(sreachTerm);
                        return null;
                    }, null, (r) =>
                    {
                        this.Close();
                    });
                }
            }
        }

        private void searchBtn_Paint(object sender, PaintEventArgs e)
        {

        }

        private void sreachText_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
                fullTextSearch();

        }

        private void sreachText_TextChanged(object sender, EventArgs e)
        {
          
        }

        void txt_LostFocus(object sender, EventArgs e)
        {
           
        }

        private void sreachLabel_Click(object sender, EventArgs e)
        {
            fullTextSearch();
        }

        private void sreachText_MouseHover(object sender, EventArgs e)
        {
            showTip((Control)sender);
        }

        private void sreachLabel_MouseHover(object sender, EventArgs e)
        {
            showTip((Control)sender);
        }
    }
}
