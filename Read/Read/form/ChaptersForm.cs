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
    public partial class ChaptersForm : BaseForm
    {
        public ChaptersForm()
        {
            InitializeComponent();
        }

        public event MainForm.TransfDelegate TransfEvent;
        public static Boolean filterChecked = true;   //是否开启过滤功能


        private void Chapter_Load(object sender, EventArgs e)
        {
            UnderscoreBox.BackColor = BaseForm.foreColor;
            titleBox.Text = "章节";
            //样式设置
            catalogDgv.BackgroundColor = backColor;
            catalogDgv.DefaultCellStyle.BackColor = backColor;
            catalogDgv.RowHeadersVisible = false;
            catalogDgv.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            catalogDgv.AdvancedCellBorderStyle.Right = DataGridViewAdvancedCellBorderStyle.None;
            catalogDgv.AdvancedCellBorderStyle.Top = DataGridViewAdvancedCellBorderStyle.None;
            catalogDgv.AdvancedCellBorderStyle.Left = DataGridViewAdvancedCellBorderStyle.None;
            catalogDgv.AdvancedCellBorderStyle.Bottom = DataGridViewAdvancedCellBorderStyle.None;
            catalogDgv.Columns[3].Visible = false;

            //   filterTB.BorderColor = foreColor;
            filterTB.BackColor = backColor;
            filterTB.ForeColor = foreColor;
            //  filterTB.box.TextChanged += filterTB_TextChanged;

            //      ruleTypeCmb.BackColor = backColor;
            //  ruleTypeCmb.ForeColor = foreColor;

            //if (Common.notBlank(Setting.get().Rule))
            //{
            //    switch (Setting.get().Rule)
            //    {
            //        case "章":
            //            zhang.Checked = true;
            //            break;
            //        case "回":
            //            hui.Checked = true;
            //            break;
            //        case "部":
            //            bu.Checked = true;
            //            break;
            //        case "集":
            //            ji.Checked = true;
            //            break;
            //        case "卷":
            //            juan.Checked = true;
            //            break;
            //        case "篇":
            //            pian.Checked = true;
            //            break;
            //    }
            //}
            //  ruleTypeCmb.SelectedIndex = Setting.get().RuleType;
            List<Chapter> chapters = Chapter.get();
            if (chapters != null && chapters.Count > 0)
            {
                catalogDgv.DataSource = new BindingList<Chapter>(chapters);
                //  ruleTypeCmb.Enabled = true;
            }

        }




        /// <summary>
        /// 修改分章节字符
        /// </summary>
        /// <param name="cb"></param>
        public void modify(RadioButton cb)
        {
            if (!Setting.get().Rule.Equals(cb.Text))
            {
                Setting s = Setting.get();
                s.Rule = cb.Text;
                Setting.save(s);
                ScanningChapters();
            }
        }

        private void bu_CheckedChanged(object sender, EventArgs e)
        {
            modify((RadioButton)sender);
        }


        /// <summary>
        /// 根据输入的关键字筛选目录 
        /// </summary>
        public void filter()
        {
            //  filterChecked = filterCB.Checked;
            List<Chapter> chapters = Chapter.get();
            String filterStr = filterTB.Text;
            if (Common.notBlank(filterStr) && chapters != null)
            {
                List<Chapter> filterList = new List<Chapter>();
                foreach (Chapter c in chapters)
                {
                    if (Common.notBlank(c.CatalogName) && c.CatalogName.Contains(filterStr))
                    {
                        filterList.Add(c);
                    }
                }
                catalogDgv.DataSource = new BindingList<Chapter>(filterList);
                return;
            }
            catalogDgv.DataSource = new BindingList<Chapter>(chapters);
        }

        private void filterCB_CheckedChanged(object sender, EventArgs e)
        {
            filter();
        }

        /// <summary>
        /// 值改变事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void filterTB_TextChanged(object sender, EventArgs e)
        {
            filter();
        }

        private void ruleTypeCmb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Setting s = Setting.get();
            //  s.RuleType = Convert.ToInt16(ruleTypeCmb.SelectedIndex);
            Setting.save(s);
            ScanningChapters();
        }


        //扫描书籍目录
        public void ScanningChapters()
        {
            if (Common.isBlank(Setting.get().Rule) || ReadCache.maxPageNum == 0)
            {
                return;
            }

            showMessage("获取书籍章节目录中....");
            closeLabel.Enabled = false;
            this.DoWorkAsync((o) =>
            {
                //  ruleTypeCmb.Enabled = false;
                Chapter.init();
                return null;
            }, null, (r) =>
            {
                showMessage(Chapter.get().Count == 0 ? "当前条件获取章节目录失败" : "已获取书籍章节目录");
                catalogDgv.DataSource = new BindingList<Chapter>(Chapter.get()); ;
                // ruleTypeCmb.Enabled = true;
                closeLabel.Enabled = true;
            });
        }

        private void catalogDgv_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int index = catalogDgv.CurrentRow.Index;
            ReadCache.nowPageNum = (int)catalogDgv.Rows[index].Cells[3].Value;
            //异步调用去加载书籍并扫描书籍目录
            this.DoWorkAsync((o) =>
            {
                TransfEvent(ReadService.ReadBook(false));
                return null;
            }, null, (r) =>
            {
                this.Close();
            });
        }

        private void catalogDgv_DataSourceChanged(object sender, EventArgs e)
        {
            if (Chapter.get().Count > ReadCache.catalogNum && this.catalogDgv.Rows.Count > ReadCache.catalogNum)
            {
                this.catalogDgv.BindingContext[this.catalogDgv.DataSource].Position = ReadCache.catalogNum;
                this.catalogDgv.CurrentCell = this.catalogDgv.Rows[ReadCache.catalogNum].Cells[0];
            }
        }

        private void controlPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void sreachLabel_Click(object sender, EventArgs e)
        {
          
        }

        private void 刷新ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.DoWorkAsync((o) =>
            {
                Chapter.init();
                return null;
            }, null, (r) =>
            {
                showMessage("已重新获取书籍目录");
            });
        }

    }
}
