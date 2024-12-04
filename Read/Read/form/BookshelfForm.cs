
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
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsApplication8;

namespace Read.form
{
    public partial class BookshelfForm : BaseForm
    {

        private RichTextBox bookBox;

        public BookshelfForm(RichTextBox bookText)
        {
            InitializeComponent();
            bookBox = bookText;
        }

        public event MainForm.TransfDelegate TransfEvent;


        public delegate void refreshBookDgv();
        void refresh()
        {
            List<Book> list = Book.get();
            if (list != null)
                bookDgv.DataSource = new BindingList<Book>(list);
        }

        private void OpenBook_Load(object sender, EventArgs e)
        {
            titleBox.Text = "书架";
            List<Book> list = Book.get();
            if (list != null && list.Count > 0)
            {
                bookDgv.DataSource = new BindingList<Book>(list);
            }
        }

        private void 手动选择ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Multiselect = true;//该值确定是否可以选择多个文件
            dialog.Title = "请选择书籍";
            dialog.Filter = "文本文件(*.txt)|*.txt";
            dialog.InitialDirectory = Common.getSystemUrl();
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                List<Book> list = Book.get();
                for (int i = 0; i < dialog.FileNames.Length; i++)
                {
                    FileInfo fi = new FileInfo(dialog.FileNames[i]);
                    ImportBook(list, fi);
                }
                showMessage("指定书籍已加入书架");
                Book.save(list);
                bookDgv.DataSource = new BindingList<Book>(list);
            }
        }

        /// <summary>
        /// 导入书籍
        /// </summary>
        /// <param name="list"></param>
        /// <param name="fi"></param>
        public static Book ImportBook(List<Book> list, FileInfo fi)
        {
            Book book;
            String url = fi.FullName.Replace("\\", "/");
            if (!list.Exists(t => url.Equals(t.Url)))
            {
                 book = new Book();
                book.Url = url;
                book.Name = Path.GetFileNameWithoutExtension(fi.FullName);
                book.ReadPercent = 0;
                book.LastReadTime = "-";
                book.Size = Common.CountSize(fi.Length);
                book.NowPageNum = 1;
                book.MaxPageNum = 0;
            }
            else
            {
                book = list.Find(t => url.Equals(t.Url));
                //已经存在的书籍不改动 只调整位置
                list.Remove(book);
            }
            list.Insert(0, book);
            return book;
        }


        private void 移除失效书籍ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<Book> list = Book.get();
            for (int i = list.Count - 1; i >= 0; i--)
            {
                if (!Common.isExist(list[i].Url)) list.RemoveAt(i);
            }
            Book.save(list);
            bookDgv.DataSource = new BindingList<Book>(list);
            showMessage("已移除失效的书籍");
        }

        private void 移除所选文件ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //支持批量删除
            List<Book> list = Book.get();
            List<String> paths = new List<string>();
            //获取选中文件路径集合
            for (int i = 0; i < bookDgv.SelectedRows.Count; i++)
            {
                paths.Add(Common.toString(bookDgv.SelectedRows[i].Cells[0].Value));
            }
            //根据文件路径从集合中删除文件
            List<Book> newList = list.Where(book =>
            {
                if (ReadCache.bookUrl.Equals(book.Url))
                {
                    showMessage("正在阅读的书籍不可移出");
                    return true;
                }
                return !paths.Contains(book.Url);
            }).ToList();

            Book.save(newList);
            bookDgv.DataSource = new BindingList<Book>(newList);
        }

        private void 复制文件路径ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StringBuilder urls = new StringBuilder();
            for (int i = bookDgv.SelectedRows.Count - 1; i >= 0; i--)
            {
                urls.Append(bookDgv.SelectedRows[i].Cells[0].Value).Append("\n");
            }
            if (urls.Length > 0)
            {
                Clipboard.SetDataObject(urls.ToString());
                showMessage("已复制所选中书籍的路径");
            }
        }

        String defaultPath = "";

        private void 扫描文件夹ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.FolderBrowserDialog dialog = new System.Windows.Forms.FolderBrowserDialog();
            dialog.Description = "请选择Txt所在文件夹";
            //设置此次默认目录为上一次选中目录
            if (Common.notBlank(defaultPath))
                dialog.SelectedPath = defaultPath;
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (string.IsNullOrEmpty(dialog.SelectedPath))
                {
                    showMessage("文件夹路径不能为空");
                    return;
                }
                defaultPath = dialog.SelectedPath;
                SearchBookForm s = new SearchBookForm(defaultPath);
                s.refresh += refresh;
                s.ShowDialog();
                //刷新bookdgv
                bookDgv.DataSource = new BindingList<Book>(Book.get());
            }
        }

        /// <summary>
        /// 从书架打开一本书
        /// </summary>
        private void openNewBook()
        {
            if (bookDgv.SelectedRows.Count > 0)
            {
                DataGridViewRow row = bookDgv.SelectedRows[0];
                Book b = new Book(Common.toString(row.Cells[0].Value), Common.toString(row.Cells[2].Value), "");
                if (!Common.isExist(b.Url))
                {
                    showMessage("该书籍已移动或已删除，无法打开");
                    return;
                }
                this.DoWorkAsync((o) =>
                {
                    b.MaxPageNum = Common.toInt(row.Cells[9].Value);
                    b.NowPageNum = Common.toInt(row.Cells[8].Value);
                    String percentage = Common.toString(row.Cells[4].Value).Replace("%", "");//保持高精度
                    ReadCache.newReadCache(b, bookBox, percentage);
                    Chapter.init();
                    Dictionary<int, String> value = ReadService.ReadBook(false);
                    TransfEvent(value);
                    return null;
                }, null, (r) =>
                {
                    bookBox.Show();
                    this.Close();
                });
            }
        }

         


        /// <summary>
        /// 复选框取消则取消选中高亮的效果
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bookList_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            if (!e.Item.Checked)
            {
                e.Item.Selected = false;
            }
        }

        private void tempLV_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            if (!e.Item.Checked)
            {
                e.Item.Selected = false;
            }
        }

        private void 开始阅读ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openNewBook();
        }

        private void bookDgv_DoubleClick(object sender, EventArgs e)
        {
            openNewBook();
        }

        private void 全部选中ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = bookDgv.Rows.Count - 1; i >= 0; i--)
            {
                bookDgv.Rows[i].Selected = true;
            }
        }

        private void 取消全选ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = bookDgv.Rows.Count - 1; i >= 0; i--)
            {
                bookDgv.Rows[i].Selected = false;
            }
        }

        private void bookDgv_SelectionChanged(object sender, EventArgs e)
        {
            开始阅读ToolStripMenuItem.Enabled = bookDgv.SelectedRows.Count == 1;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void messageBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void BookshelfForm_DragDrop(object sender, DragEventArgs e)
        {
            String path = ((System.Array)e.Data.GetData(DataFormats.FileDrop)).GetValue(0).ToString();
            FileInfo fi = new FileInfo(path);
            List<Book> list = Book.get();
            if (Directory.Exists(path) && alert("提示", "是否遍历该文件夹获取书籍 ?"))
            {
                defaultPath = path;
                SearchBookForm s = new SearchBookForm(defaultPath);
                s.refresh += refresh;
                s.ShowDialog();
                //刷新bookdgv
                bookDgv.DataSource = new BindingList<Book>(Book.get());

            }
            else if (path.ToLower().EndsWith(".txt"))
            {
                ImportBook(list, fi);
                Book.save(list);
                bookDgv.DataSource = new BindingList<Book>(list);
                String name = Path.GetFileNameWithoutExtension(fi.FullName);
                showMessage("\"" + name + "\" 已加入书架");
            }
            else
            {
                showMessage("只能拖入txt文件或文件夹");
            }
        }

        private void BookshelfForm_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.All;                                                              //重要代码：表明是所有类型的数据，比如文件路径
            else
                e.Effect = DragDropEffects.None;

        }


    }
}
