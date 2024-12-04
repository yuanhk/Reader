using Read.model;
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
    public partial class MainForm : BaseForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 将指定书页缓存写入阅读文本框委托事件
        /// </summary>
        /// <param name="value"></param>
        public delegate void TransfDelegate(Dictionary<int, String> value);
        void frm_TransfEvent(Dictionary<int, String> value)
        {
            bookNameText.Text = Common.notBlank(ReadCache.bookName) ? ReadCache.bookName.Replace(".txt", "") : ReadCache.bookName;
            ReadCache.pageList = value;
            jumpPage(0);
        }

        /// <summary>
        /// 高亮显示指定文字
        /// </summary>
        /// <param name="value"></param>
        public delegate void highlight(String str);
        void frm_highlight(String str)
        {
            int startIndex = 0;
            while ((startIndex = bookText.Find(str, startIndex + 1, RichTextBoxFinds.None)) > -1)
            {
                bookText.SelectionStart = startIndex;
                //得到字符串的长度
                bookText.SelectionLength = str.Length;
                //然后就可以改变这个字符串的颜色
                bookText.SelectionColor = tipColor;
            }
        }


        /// <summary>
        /// 前后跳转指定数量页码
        /// </summary>
        /// <param name="add"></param>
        /// <returns></returns>
        bool jumpPage(int add)
        {
            try
            {
                ReadCache.nowPageNum += add;//页码改变
                //指定的开始行和结束行
                int pageLineStart = (ReadCache.nowPageNum - 1) * ReadCache.lineSize + 1;
                int pageLineEnd = ReadCache.nowPageNum * ReadCache.lineSize;
                //判断页码变更后是否存在,不存在则恢复
                if (!ReadCache.pageList.ContainsKey(pageLineStart))
                {
                    ReadCache.nowPageNum -= add;
                    return false;
                }
                //显示文本
                bookText.Clear();
                StringBuilder sb = new StringBuilder();
                if (ReadCache.pageList.ContainsKey(pageLineStart))
                    sb.Append(ReadCache.pageList[pageLineStart]);
                for (int i = ++pageLineStart; i <= pageLineEnd; i++)
                {
                    if (ReadCache.pageList.ContainsKey(i))
                        sb.Append("\r\n" + ReadCache.pageList[i]);
                }
                bookText.AppendText(sb.ToString());
                //阅读相关信息展示
                nowCount.Text = ReadCache.nowPageNum.ToString();
                if (ReadCache.maxPageNum != 0)
                {
                    maxCount.Text = ReadCache.maxPageNum.ToString();
                    //计算进度 保留两位位小数
                    Decimal now = Decimal.Parse(nowCount.Text);
                    Decimal max = Decimal.Parse(maxCount.Text);
                    Decimal d = ReadCache.readPercent = now / max * 100;
                    percentage.Text = Decimal.Round(d, 2) + "%";
                    //进度条赋值 四舍五入不保留小数
                    ReadBar.Value = Decimal.ToInt32(decimal.Round(d, 0, MidpointRounding.AwayFromZero)) * 100;

                    //计算当前章节
                    CatalogText.Text = "";
                    List<Chapter> catalogs = Chapter.get();
                    if (catalogs != null)
                    {
                        for (int i = catalogs.Count - 1; i >= 0; i--)
                        {
                            if (ReadCache.nowPageNum >= catalogs[i].PageNum)
                            {
                                CatalogText.Text = catalogs[i].CatalogName;
                                ReadCache.catalogNum = i;
                                break;
                            }
                        }
                    }
                }
                return true;
            }
            catch (Exception e)
            {
                Common.saveLog("MainForm-getText:" + e.Message);
                return false;
            }
        }

        /// <summary>
        /// 窗体加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Main_Load(object sender, EventArgs e)
        {
            titleBox.Visible = false;
            bookText.MouseDown += new MouseEventHandler(this.cannot_getFocus);
            CatalogText.MouseDown += new MouseEventHandler(cannot_getFocus);
            bookNameText.MouseDown += new MouseEventHandler(cannot_getFocus);
            percentage.MouseDown += new MouseEventHandler(cannot_getFocus);
            nowCount.MouseDown += new MouseEventHandler(cannot_getFocus);
            textBox1.MouseDown += new MouseEventHandler(cannot_getFocus);
            maxCount.MouseDown += new MouseEventHandler(cannot_getFocus);
            //消息提示框居中显示
            messageBox.Left = (Width - messageBox.Width) / 2;
            this.DoWorkAsync((o) =>
            {
                loadLastRead();
                return null;
            }, null, (r) =>
            {
                bookText.Show();
                if (Book.get().Count == 0 || Common.isBlank(Book.get()[0].Name))
                    showMessage("书架中没有可以阅读的书籍");
                else if (!Common.isExist(Book.get()[0].Url))
                    showMessage("书籍已移动位置或已删除");
            });
        }

        public void loadLastRead()
        {
            //载入最近阅读的一本书
            List<Book> books = Book.get();
            if (books.Count > 0 && Common.notBlank(books[0].Name) && Common.isExist(books[0].Url))
            {
                Book b = books[0];
                ReadCache.newReadCache(b, this.bookText, b.ReadPercent.ToString());
                //扫描书籍目录，读取指定页码书籍
                Chapter.init();
                Dictionary<int, String> value = ReadService.ReadBook(false);
                frm_TransfEvent(value);
            }
        }


        /// <summary>
        /// 翻页按钮设置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void downPageLabel_MouseLeave(object sender, EventArgs e)
        {
            ((Control)sender).Height = 17;
            ((Control)sender).ForeColor = foreColor;
        }

        private void downPageLabel_MouseEnter(object sender, EventArgs e)
        {
            ((Control)sender).Height = 30;
            ((Control)sender).ForeColor = tipColor;

        }

        private void lastPage_Click(object sender, EventArgs e)
        {
            previousPage();
        }

        private void nextPage_Click(object sender, EventArgs e)
        {
            nextPage();
        }
        //上一页
        public void previousPage()
        {
            if (Common.isBlank(ReadCache.bookUrl))
                showMessage("尚未载入书籍");
            else if (ReadCache.nowPageNum <= 1)
                showMessage("已阅读至首页");
            else
                jumpPage(-1);
        }

        //下一页
        public void nextPage()
        {
            if (Common.isBlank(ReadCache.bookUrl))
                showMessage("尚未载入书籍");
            else if (ReadCache.nowPageNum >= int.Parse(maxCount.Text))
                showMessage("已阅读至尾页");
            else
                jumpPage(1);
        }

        /// <summary>
        /// 当前页码变动后自动判断是否重新读取书籍
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nowCount_TextChanged(object sender, EventArgs e)
        {
            if (ReadCache.nowPageNum % 3 == 0)
            {
                startTask(delegate()
                {
                    ReadCache.pageList = ReadService.ReadBook(false);
                });
            }
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            saveLastRead();
            System.Environment.Exit(0);
        }

        private void ReadBar_MouseUp(object sender, MouseEventArgs e)
        {
            if (Common.isBlank(ReadCache.bookUrl))
            {
                showMessage("尚未载入书籍");
                return;
            }
            startTask(delegate()
            {
                ReadCache.nowPageNum = Common.toInt(nowCount.Text, 1);
                Dictionary<int, String> value = ReadService.ReadBook(false);
                frm_TransfEvent(value);
            });
        }

        private void ReadBar_Click(object sender, EventArgs e)
        {
            ProgressBar bar = ((ProgressBar)sender);
            Point p1 = this.PointToClient(MousePosition);//鼠标相对于窗体的坐标
            Point p2 = bar.Location;//进度条相对于窗体的坐标
            ((ProgressBar)sender).Value = (int)((p1.X - p2.X) / (bar.Width * 0.0001));
            //  percentage.Text = ReadBar.Value / 100.00 + "%"; //跳页后自动赋值
            int now = ReadBar.Value * ReadCache.maxPageNum / 10000;
            nowCount.Text = (now > 0 ? now : 1) + "";
        }

        private void myBooks_MouseHover(object sender, EventArgs e)
        {
            showTip((Control)sender);
        }

        private void addmarker_MouseEnter(object sender, EventArgs e)
        {
            PictureBox p = (PictureBox)sender;
            p.BackColor = foreColor;
            p.Left--;
        }


        private void addmarker_MouseLeave(object sender, EventArgs e)
        {
            ((PictureBox)sender).BackColor = Color.Transparent;
            ((PictureBox)sender).Left++;
        }

        private void qiyongMenu_Click(object sender, EventArgs e)
        {
            if (qiyongMenu.Text.Equals("选中文本"))
            {
                qiyongMenu.Text = "关闭选中";
                fuzhiMenu.Visible = true;
                sousuoMenu.Visible = true;
                jiansuoMenu.Visible = true;
                this.bookText.MouseDown -= new MouseEventHandler(cannot_getFocus);
                bookText.Cursor = Cursors.IBeam;
            }
            else
            {
                qiyongMenu.Text = "选中文本";
                fuzhiMenu.Visible = false;
                sousuoMenu.Visible = false;
                jiansuoMenu.Visible = false;
                bookText.SelectionLength = 0;
                this.bookText.MouseDown += new MouseEventHandler(cannot_getFocus);
                scapegoat.Focus();
                bookText.Cursor = Cursors.Default;
            }
        }

        private void fuzhiMenu_Click(object sender, EventArgs e)
        {
            String str = bookText.SelectedText;
            if (Common.notBlank(str))
            {
                Clipboard.SetDataObject(str);
                showMessage("选中文本已复制到剪切板");
            }
        }

        private void sousuoMenu_Click(object sender, EventArgs e)
        {
            String str = bookText.SelectedText;
            if (Common.notBlank(str))
                System.Diagnostics.Process.Start("https://www.baidu.com/s?ie=UTF-8&wd=" + str);

        }

        private void jiansuoMenu_Click(object sender, EventArgs e)
        {
            String str = bookText.SelectedText;
            if (Common.notBlank(str))
            {
                FullTextSearchForm.sreachTerm = str;
                FullTextSearchForm form = new FullTextSearchForm();
                form.TransfEvent += frm_TransfEvent;
                form.highlight += frm_highlight;
                form.ShowDialog(this);
            }

        }

        private void myBooks_Click(object sender, EventArgs e)
        {
            saveLastRead();
            BookshelfForm open = new BookshelfForm(this.bookText);
            open.TransfEvent += frm_TransfEvent;
            //选择书籍窗体注册事件
            open.ShowDialog(this);
        }

        private void catalogs_Click(object sender, EventArgs e)
        {
            ChaptersForm chapter = new ChaptersForm();
            chapter.TransfEvent += frm_TransfEvent;
            //选择书籍窗体注册事件
            chapter.ShowDialog(this);
        }

        private void addmarker_Click(object sender, EventArgs e)
        {
            if (Common.isBlank(ReadCache.bookUrl))
            {
                showMessage("尚未载入书籍");
                return;
            }
            //如果有章节 取当前章节 无则取文本前25个字预览
            DateTime time = System.DateTime.Now;
            Double d = ReadCache.nowPageNum * 100.00 / ReadCache.maxPageNum;
            Marker mk = new Marker(ReadCache.bookName, ReadCache.bookUrl, d, getChapter(), time.ToString("yyyy-MM-dd HH:mm"));
            mk.MaxPageNum = ReadCache.maxPageNum;
            mk.NowPageNum = ReadCache.nowPageNum;
            List<Marker> list = Marker.get();
            list.Add(mk);
            Marker.save(list);
            showMessage("已加入书签");
        }

        private void markers_Click(object sender, EventArgs e)
        {
            MarkersForm marker = new MarkersForm(this.bookText);
            marker.TransfEvent += frm_TransfEvent;
            marker.ShowDialog(this);
        }

        private void sreach_Click(object sender, EventArgs e)
        {
            FullTextSearchForm form = new FullTextSearchForm();
            form.TransfEvent += frm_TransfEvent;
            form.highlight += frm_highlight;
            form.ShowDialog(this);
        }

        private void hotkeys_Click(object sender, EventArgs e)
        {
            HotKeyForm form = new HotKeyForm();
            form.ShowDialog(this);
        }

        private void setting_Click(object sender, EventArgs e)
        {
            saveLastRead();//保存阅读记录
            SettingForm form = new Form(this);
            form.ShowDialog(this);
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            saveLastRead();
            if (alert("提示", "确定重新载入当前书籍?"))
            {
                this.Hide();  //先隐藏主窗体
                MainForm form1 = new MainForm(); //重新实例化此窗体
                form1.ShowDialog();//已模式窗体的方法重新打开
                this.Close();//原窗体关闭
            }
        }
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }

        private void MainForm_DragDrop(object sender, DragEventArgs e)
        {
            String path = ((System.Array)e.Data.GetData(DataFormats.FileDrop)).GetValue(0).ToString();
            path = path.Replace('\\', '/');
            if (path.ToLower().EndsWith(".txt"))
            {
                if (ReadCache.bookUrl.Equals(path))
                {
                    showMessage("此书籍正在阅读");
                    return;
                }
                List<Book> list = Book.get();
                FileInfo fi = new FileInfo(path);
                Book book = BookshelfForm.ImportBook(list, fi);
                Book.save(list);
                String name = Path.GetFileNameWithoutExtension(fi.FullName);
                bool b = alert("提示", "\"" + name + "\" 已加入书架 , 是否" + ("-".Equals(book.lastReadTime) ? "开始阅读?" : "继续阅读?"));
                if (b)
                {
                    this.DoWorkAsync((o) =>
                    {
                        loadLastRead();
                        return null;
                    }, null, (r) =>
                    {
                        bookText.Show();
                        if (Book.get().Count == 0 || Common.isBlank(Book.get()[0].Name))
                            showMessage("书架中没有可以阅读的书籍");
                        else if (!Common.isExist(Book.get()[0].Url))
                            showMessage("书籍已移动位置或已删除");
                    });
                }
            }
            else
            {
                showMessage("目前只支持txt格式的书籍");
            }
        }

        private void MainForm_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.All;                                                              //重要代码：表明是所有类型的数据，比如文件路径
            else
                e.Effect = DragDropEffects.None;
        }


        private void jump(int count)
        {
            this.DoWorkAsync((o) =>
                        {
                            foreach (Chapter c in Chapter.get())
                            {
                                if (c.catalogNo == ReadCache.catalogNum + count)
                                {
                                    ReadCache.nowPageNum = c.PageNum;
                                    frm_TransfEvent(ReadService.ReadBook(false));
                                    break;
                                }
                            }
                            return null;
                        }, null, (r) =>
                        { });
        }

        private void label1_Click(object sender, EventArgs e)
        {
            jump(2);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            jump(0);
        }

        private void 添加书签ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Common.isBlank(ReadCache.bookUrl))
            {
                showMessage("尚未载入书籍");
                return;
            }
            //如果有章节 取当前章节 无则取文本前25个字预览
            DateTime time = System.DateTime.Now;
            Double d = ReadCache.nowPageNum * 100.00 / ReadCache.maxPageNum;
            Marker mk = new Marker(ReadCache.bookName, ReadCache.bookUrl, d, getChapter(), time.ToString("yyyy-MM-dd HH:mm"));
            mk.MaxPageNum = ReadCache.maxPageNum;
            mk.NowPageNum = ReadCache.nowPageNum;
            List<Marker> list = Marker.get();
            list.Add(mk);
            Marker.save(list);
            showMessage("已加入书签");
        }

   
     

        private void label1_MouseClick(object sender, MouseEventArgs e)
        {
            if (panel2.Visible)
            {
                panel2.Visible = false;
                label1.Text = "﹀";
            }
            else {
                panel2.Visible = true;
                label1.Text = "︿";
            }
        }

        private void bookText_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
