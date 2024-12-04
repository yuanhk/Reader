using Read.plugin;
using Reader.model;
using Reader.services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsApplication8;

namespace Read.form
{
    public partial class MarkersForm : BaseForm
    {
        private RichTextBox bookBox;

        public MarkersForm(RichTextBox bookText)
        {
            InitializeComponent();
            bookBox = bookText;
        }

        public event MainForm.TransfDelegate TransfEvent;

        private void Marker_Load(object sender, EventArgs e)
        {
            markerDgv.DataSource = new BindingList<Marker>(Marker.get());
            titleBox.Text = "书签";
        }

        private void markerlv_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            if (!e.Item.Checked)
            {
                e.Item.Selected = false;
            }
        }

        private void 移除失效书籍ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<Marker> list = Marker.get();
            for (int i = list.Count - 1; i >= 0; i--)
            {
                if (!Common.isExist(list[i].Url)) list.RemoveAt(i);
            }
            Marker.save(list);
            markerDgv.DataSource = new BindingList<Marker>(list);
        }

        private void 手动选择ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            delete();
        }

        private void delete()
        {
            if (markerDgv.SelectedRows.Count <= 0) return;
            foreach (DataGridViewRow row in markerDgv.SelectedRows)
            {
                markerDgv.Rows.Remove(row);
            }
            List<Marker> list = new List<Marker>((BindingList<Marker>)this.markerDgv.DataSource);
            Marker.save(list);
        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            delete();
        }


        private void loadMarker()
        {
            if (markerDgv.SelectedRows.Count <= 0) return;
            DataGridViewRow row = markerDgv.SelectedRows[0];

            //初始化查询参数
            Book b = new Book();
            b.Name = Common.toString(row.Cells[0].Value);
            b.Url = Common.toString(row.Cells[1].Value);
            if (!File.Exists(b.Url))
            {
                showMessage("因文件已删除或移动位置，该书签已失效");
                this.Enabled = true;
                return;
            }
            saveLastRead();//保存加载书签前的阅读记录
            String percentage = Common.toString(row.Cells[2].Value);//保持高精度
            b.MaxPageNum = Common.toInt(row.Cells[7].Value);
            b.NowPageNum = Common.toInt(row.Cells[6].Value);
            this.DoWorkAsync((o) => //耗时逻辑处理(此处不能操作UI控件，因为是在异步中)
            {
                //创建新的阅读缓存
                ReadCache.newReadCache(b, bookBox, percentage);
                Chapter.init();
                Dictionary<int, String> value = ReadService.ReadBook(false);
                TransfEvent(value);
                return null;

            }, null, (r) => //显示结果（此处用于对上面结果的处理，比如显示到界面上）
            {
                saveLastRead();//保存加载书签后的阅读记录
                bookBox.Show();
                this.Close();
            });
        }

        private void markerlv_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            loadMarker();
        }

        private void 继续阅读ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadMarker();
        }

        private void markerDgv_SelectionChanged(object sender, EventArgs e)
        {
            继续阅读ToolStripMenuItem.Enabled = markerDgv.SelectedRows.Count == 1;
        }

        private void markerDgv_DoubleClick(object sender, EventArgs e)
        {
            loadMarker();
        }

    }
}
