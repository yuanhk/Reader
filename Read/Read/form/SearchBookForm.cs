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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Read.form
{
    public partial class SearchBookForm : BaseForm
    {
        private String searchUrl = "";
        public SearchBookForm(String url)
        {
            InitializeComponent();
            searchUrl = url;
        }

        public event BookshelfForm.refreshBookDgv refresh;

        private void Main_Load(object sender, EventArgs e)
        {
            titleBox.Text = "导入书架";
            sreachBooks();
        }

        public void sreachBooks()
        {
            //异步遍历文件夹获取书籍列表 
            this.DoWorkAsync((o) =>
            {
                List<Book> result = new List<Book>();
                if (Directory.Exists(searchUrl))
                {
                    List<Book> a = ReadService.scanningFolder(searchUrl), b = Book.get();
                    searchUrl = searchUrl.Replace("\\", "/");
                    foreach (Book j in a)
                    {
                        if (!b.Exists(p => p.Url.Equals(j.Url)))
                        {
                            j.PartUrl = j.Url.Replace(searchUrl, "").Replace("/" + j.Name, "").Replace(".txt", "");
                            result.Add(j);
                        }
                    }
                }
                return result;
            }, null, (r) =>
            {
                searchResultDgv.DataSource = new BindingList<Book>(r);
            });
        }



        private void 导入书架ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            importSelectedBooks(searchResultDgv.SelectedRows);
        }

        private void 在文件夹中打开ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (searchResultDgv.SelectedRows.Count == 1)
            {
                String path = Common.toString(searchResultDgv.SelectedRows[0].Cells[0].Value);
                FileInfo f = new FileInfo(path);
                Common.ExplorerFile(f.FullName);
            }
        }

        private void searchResultDgv_SelectionChanged(object sender, EventArgs e)
        {
            在文件夹中打开ToolStripMenuItem.Enabled = searchResultDgv.SelectedRows.Count == 1;
        }

        private void 导入书籍ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            importSelectedBooks(searchResultDgv.SelectedRows);
        }

        private void importSelectedBooks(DataGridViewSelectedRowCollection rows)
        {
            List<Book> addList = new List<Book>();
            foreach (DataGridViewRow row in rows)
            {
                Book temp = new Book();
                temp.Name = Common.toString(row.Cells[2].Value);
                temp.Size = Common.toString(row.Cells[3].Value);
                temp.Url = Common.toString(row.Cells[0].Value);
                temp.LastReadTime = "-";
                addList.Add(temp);
                searchResultDgv.Rows.Remove(row);
            }
            Book.append(addList);
            showMessage("成功导入" + addList.Count + "本书籍");
            refresh();
        }

        private void 导入所有ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            searchResultDgv.SelectAll();
            importSelectedBooks(searchResultDgv.SelectedRows);
        }

    }
}
