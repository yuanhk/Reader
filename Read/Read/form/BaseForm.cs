using Orange.control;
using Read.model;
using Read.plugin;
using Read.service;
using Reader.model;
using Reader.services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsApplication8;

namespace Read.form
{
    public partial class BaseForm : Form
    {
        public BaseForm()
        {
            InitializeComponent();
        }

        //背景色
        public static Color backColor = Color.FromArgb(51, 63, 80);
        //字体色
        public static Color foreColor = Color.FromArgb(180, 181, 182);
        //提示颜色
        public static Color tipColor = Color.Tomato;
        //全局最小化的按键码下标
        public String minKeyName = "NumPad1";
        //全局关闭的按键码下标
        public String closeKeyName = "NumPad2";

        private void BaseForm_Load(object sender, EventArgs e)
        {
            //取消线程间调用的错误捕获
            Control.CheckForIllegalCrossThreadCalls = false;
            ResetStting();
            //全局热键
            HotKey.get();
            minKeyName = HotKey.getKeyCode(6);
            closeKeyName = HotKey.getKeyCode(7);
            //其他设置
            separationLine.Left = 10;
            separationLine.Width = Width - 20;
            scapegoat.Focus();
        }

        //重置设置
        public void ResetStting() {
            //读取设置
            Setting s = Setting.get();
            //字体颜色
            foreColor = ColorUtil.colorHx16toRGB(s.ForeColor, foreColor);
            //背景颜色
            backColor = ColorUtil.colorHx16toRGB(s.BackColor, backColor);
            //提示消息颜色
            tipColor = ColorUtil.colorHx16toRGB(s.MessageColor, tipColor);
            //窗体颜色设置
            this.BackColor = backColor;
            this.ForeColor = foreColor;

            //遍历所有控件设置颜色
            foreach (Control control in this.Controls)
            {
                control.BackColor = backColor;
                control.ForeColor = foreColor;
                //表格样式设置
                if (control is DataGridView)
                {
                    DataGridView dgv = (DataGridView)control;
                    dgv.BackgroundColor = backColor;
                    dgv.DefaultCellStyle.BackColor = backColor;
                    dgv.RowHeadersVisible = false;
                    dgv.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
                    dgv.AdvancedCellBorderStyle.Right = DataGridViewAdvancedCellBorderStyle.None;
                    dgv.AdvancedCellBorderStyle.Top = DataGridViewAdvancedCellBorderStyle.None;
                    dgv.AdvancedCellBorderStyle.Left = DataGridViewAdvancedCellBorderStyle.None;
                    dgv.AdvancedCellBorderStyle.Bottom = DataGridViewAdvancedCellBorderStyle.None;
                }
                //设置边框颜色
                if (control is ButtonEx || control is TextBoxEx || control is PanelEx)
                    ((PanelEx)control).BorderColor = foreColor;
                //菜单栏样式美化
                else if (control is MenuStrip)
                {
                    MenuStrip menuStrip = (MenuStrip)control;
                    menuStrip.Renderer = new MenuItemRenderer(menuStrip.Font, foreColor);
                }
                else if (control is RichTextBox)
                {
                    RichTextBox box = (RichTextBox)control;
                    box.Font = new Font(s.FontStyle, s.FontSize, box.Font.Style);
                }
            }
            //单独设置颜色的控件
            separationLine.BackColor = foreColor;
            messageBox.ForeColor = tipColor;
            //替罪羊获取焦点~
            scapegoat.Focus();
        }

        /// <summary>
        /// 禁止文本框控件获取焦点,鼠标按下时焦点跳转到一个隐藏文本框上（scapegoat）
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void cannot_getFocus(object sender, MouseEventArgs e)
        {
            scapegoat.Focus();
        }


        /// <summary>
        /// 允许鼠标拖动面板
        /// </summary>
        private Point mPoint = new Point();

        private void Base_MouseDown(object sender, MouseEventArgs e)
        {
            mPoint.X = e.X;
            mPoint.Y = e.Y;
        }

        private void Base_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point myPosittion = MousePosition;
                myPosittion.Offset(-mPoint.X, -mPoint.Y);
                Location = myPosittion;
            }
        }


        /// <summary>
        /// 右上角按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpperRightCorner_Click(object sender, EventArgs e)
        {
            if ((Label)sender == minLabel)
                this.WindowState = FormWindowState.Minimized;
            else
                this.Close();
        }

        private void UpperRightCorner_MouseEnter(object sender, EventArgs e)
        {
            ((Label)sender).ForeColor = tipColor;
        }

        private void UpperRightCorner_MouseLeave(object sender, EventArgs e)
        {
            ((Label)sender).ForeColor = foreColor;
        }

        private void UpperRightCorner_MouseHover(object sender, EventArgs e)
        {
            showTip((Control)sender);
        }

        /// <summary>
        /// 鼠标悬浮提示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        ToolTip toolTip;

        public void showTip(Control sender)
        {
            if (toolTip != null)
                toolTip.Dispose();
            toolTip = new ToolTip();
            // 设置显示样式
            toolTip.AutoPopDelay = 2000;//提示信息的可见时间
            toolTip.InitialDelay = 0;//事件触发多久后出现提示
            toolTip.ReshowDelay = 0;//指针从一个控件移向另一个控件时，经过多久才会显示下一个提示框
            toolTip.ShowAlways = true;//是否显示提示框
            toolTip.ForeColor = tipColor;
            //  设置伴随的对象.
            toolTip.SetToolTip(sender, sender.Tag.ToString());//设置提示按钮和提示内容
        }

        /// <summary>
        /// 保存最后阅读历史
        /// </summary>
        public static void saveLastRead()
        {
            if (!Common.isExist(ReadCache.bookUrl)) return;
            List<Book> list = Book.get();
            Book b = new Book();
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Url.Equals(ReadCache.bookUrl))
                {
                    b = list[i];
                    break;
                }
            }
            b.Name = ReadCache.bookName;
            b.Url = ReadCache.bookUrl;
            b.Size = Common.getSize(b.Url);
            b.ReadPercent = ReadCache.readPercent;
            b.Chapter = getChapter();
            b.LastReadTime = System.DateTime.Now.ToString("yyyy-MM-dd HH:mm");
            b.MaxPageNum = ReadCache.maxPageNum;
            b.NowPageNum = ReadCache.nowPageNum;
            Book.save(b);
        }
        /// <summary>
        /// 获取当前阅读的预览
        /// </summary>
        /// <returns></returns>
        public static String getChapter()
        {
            try
            {
                List<Chapter> chapters = Chapter.get();
                //获取当前阅读章节
                if (chapters != null && chapters.Count > 0 && chapters.Count >= ReadCache.catalogNum)
                    return  chapters[ReadCache.catalogNum].CatalogName;
                //则取前30个字做预览
                int pageLineStart = (ReadCache.nowPageNum - 1) * ReadCache.lineSize + 1;//开始行
                StringBuilder sb = new StringBuilder();
                if (ReadCache.pageList.ContainsKey(pageLineStart))
                    sb.Append(ReadCache.pageList[pageLineStart]);
                for (int i = pageLineStart + 1; i <= ReadCache.nowPageNum * ReadCache.lineSize; i++)
                {
                    if (ReadCache.pageList.ContainsKey(i))
                        sb.Append("\r\n" + ReadCache.pageList[i]);
                }
                return sb.Length > 30 ? sb.ToString().Substring(0, 30) : sb.ToString();
            }
            catch (Exception e)
            {
                Common.saveLog("获取当前阅读章节或预览失败" + e.Message);
                return "";
            }
        }

        System.Timers.Timer messageTimer = null;
        /// <summary>
        /// 消息通知
        /// </summary>
        /// <param name="str"></param>
        public void showMessage(String str)
        {
            messageBox.Text = str;
            messageBox.Show();
            if (messageTimer != null) messageTimer.Dispose();//重新通知时销毁之前的通知任务
            messageTimer = new System.Timers.Timer(2000);
            messageTimer.Elapsed += new System.Timers.ElapsedEventHandler(cleanMessage);//到达时间的时候执行事件；
            messageTimer.AutoReset = false;//设置是执行一次（false）还是一直执行(true)；
            messageTimer.Enabled = true;//是否执行System.Timers.Timer.Elapsed事件；
        }
        /// <summary>
        /// 清除消息通知
        /// </summary>
        /// <param name="source"></param>
        /// <param name="e"></param>
        public void cleanMessage(object source, System.Timers.ElapsedEventArgs e)
        {
            messageBox.Text = "";
            messageBox.Hide();
        }


        /// <summary>
        /// 绘制边框
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Base_Paint(object sender, PaintEventArgs e)
        {
            Pen p = new Pen(backColor);
            e.Graphics.DrawRectangle(p, 0, 0, this.Width - 1, this.Height - 1);
        }

        /// <summary>
        /// 边框阴影
        /// </summary>
        /// <param name="nLeftRect"></param>
        /// <param name="nTopRect"></param>
        /// <param name="nRightRect"></param>
        /// <param name="nBottomRect"></param>
        /// <param name="nWidthEllipse"></param>
        /// <param name="nHeightEllipse"></param>
        /// <returns></returns>
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect, // x-coordinate of upper-left corner
            int nTopRect, // y-coordinate of upper-left corner
            int nRightRect, // x-coordinate of lower-right corner
            int nBottomRect, // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
         );

        [DllImport("dwmapi.dll")]
        public static extern int DwmExtendFrameIntoClientArea(IntPtr hWnd, ref MARGINS pMarInset);

        [DllImport("dwmapi.dll")]
        public static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);

        [DllImport("dwmapi.dll")]
        public static extern int DwmIsCompositionEnabled(ref int pfEnabled);

        private bool m_aeroEnabled;                     // variables for box shadow
        private const int CS_DROPSHADOW = 0x00020000;
        private const int WM_NCPAINT = 0x0085;
        private const int WM_ACTIVATEAPP = 0x001C;

        public struct MARGINS                           // struct for box shadow
        {
            public int leftWidth;
            public int rightWidth;
            public int topHeight;
            public int bottomHeight;
        }

        private const int WM_NCHITTEST = 0x84;          // variables for dragging the form
        private const int HTCLIENT = 0x1;
        private const int HTCAPTION = 0x2;

        protected override CreateParams CreateParams
        {

            get
            {
                m_aeroEnabled = CheckAeroEnabled();

                CreateParams cp = base.CreateParams;
                if (!m_aeroEnabled)
                    cp.ClassStyle |= CS_DROPSHADOW;
                const int WS_MINIMIZEBOX = 0x00020000;  // Winuser.h定义
                cp.Style = cp.Style | WS_MINIMIZEBOX;   // 单击任务栏图标最小化
                return cp;
            }
        }

        private bool CheckAeroEnabled()
        {
            if (Environment.OSVersion.Version.Major >= 6)
            {
                int enabled = 0;
                DwmIsCompositionEnabled(ref enabled);
                return (enabled == 1) ? true : false;
            }
            return false;
        }


        /// <summary>
        /// 全局热键
        /// </summary>
        private const int WM_HOTKEY = 0x312; //窗口消息-热键  
        private const int WM_CREATE = 0x1; //窗口消息-创建  
        private const int WM_DESTROY = 0x2; //窗口消息-销毁  
        private const int Space = 0x3572; //热键ID  
        private const int Space1 = 6099; //热键ID  

        /// <summary>
        /// 边框阴影
        /// </summary>
        protected override void WndProc(ref Message m)
        {
            //边框阴影
            switch (m.Msg)
            {
                case WM_HOTKEY: //窗口消息-热键ID  
                    switch (m.WParam.ToInt32())
                    {
                        case Space: //热键ID  
                            if (WindowState == FormWindowState.Minimized)
                            {
                                //还原窗体显示    
                                WindowState = FormWindowState.Normal;
                                this.ShowInTaskbar = true;
                            }
                            else
                            {
                                WindowState = FormWindowState.Minimized;
                                this.ShowInTaskbar = false;
                            }
                            break;
                        case Space1: //热键ID  
                            saveLastRead();
                            System.Environment.Exit(0);
                            break;
                        default:
                            break;
                    }
                    break;
                case WM_CREATE: //窗口消息-创建  
                    AppHotKey.RegKey(Handle, Space, AppHotKey.KeyModifiers.Ctrl | AppHotKey.KeyModifiers.Alt, Common.toKeys(minKeyName));
                    AppHotKey.RegKey(Handle, Space1, AppHotKey.KeyModifiers.Ctrl | AppHotKey.KeyModifiers.Alt, Common.toKeys(closeKeyName));
                    break;
                case WM_DESTROY: //窗口消息-销毁  
                    AppHotKey.UnRegKey(Handle, Space); //销毁热键
                    AppHotKey.UnRegKey(Handle, Space1); //销毁热键  
                    break;
                case WM_NCPAINT: //边框阴影
                    if (m_aeroEnabled)
                    {
                        var v = 2;
                        DwmSetWindowAttribute(this.Handle, 2, ref v, 4);
                        MARGINS margins = new MARGINS()
                        {
                            bottomHeight = 1,
                            leftWidth = 1,
                            rightWidth = 1,
                            topHeight = 1
                        };
                        DwmExtendFrameIntoClientArea(this.Handle, ref margins);
                    }
                    break;
                case 0xa3:  //禁止双击最大化
                    return;
                default:
                    break;
            }
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST && (int)m.Result == HTCLIENT)     // drag the form
                m.Result = (IntPtr)HTCAPTION;
        }



        /// <summary>
        /// 开启一个任务线程 异步执行，不显示遮罩层
        /// </summary>
        /// <param name="send"></param>
        /// 
        public delegate void todo();
        public void startTask(todo start)
        {
            startTask(start, null);
        }

        public void startTask(todo start, todo end)
        {
            Func<bool> longTask = new Func<bool>(delegate()
            {
                start();
                return true;
            });
            longTask.BeginInvoke(ar =>
            {
                bool result = longTask.EndInvoke(ar);
                Invoke(new Action(() =>
                {
                    if (end != null) end();
                }));
            }, null);
        }


        /// <summary>
        /// 多线程异步后台处理某些耗时的数据，不会卡死界面
        /// </summary>
        /// <param name="workFunc">Func委托，包装耗时处理（不含UI界面处理），示例：(o)=>{ 具体耗时逻辑; return 处理的结果数据 }</param>
        /// <param name="funcArg">Func委托参数，用于跨线程传递给耗时处理逻辑所需要的对象，示例：String对象、JObject对象或DataTable等任何一个值</param>
        /// <param name="workCompleted">Action委托，包装耗时处理完成后，下步操作（一般是更新界面的数据或UI控件），示列：(r)=>{ datagirdview1.DataSource=r; }</param>
        protected void DoWorkAsync(Func<object, dynamic> workFunc, object funcArg = null, Action<dynamic> workCompleted = null)
        {
            var bgWorkder = new BackgroundWorker();
            Control loadingPan = null;
            bgWorkder.WorkerReportsProgress = true;
            bgWorkder.ProgressChanged += (s, arg) =>
            {
                if (arg.ProgressPercentage > 1) return;
                #region Panel模式
                var result = this.Controls.Find("loadingPan", true);
                if (result == null || result.Length <= 0)
                {
                    loadingPan = new MaskPanel(this)
                    {
                        Name = "loadingPan"
                    };
                }
                else
                {
                    loadingPan = result[0];
                }
                loadingPan.BringToFront();
                loadingPan.Visible = true;
                #endregion
            };

            bgWorkder.RunWorkerCompleted += (s, arg) =>
            {

                #region Panel模式
                if (loadingPan != null)
                {
                    loadingPan.Visible = false;
                }
                #endregion
                bgWorkder.Dispose();

                if (workCompleted != null)
                {
                    workCompleted(arg.Result);
                }
            };
            bgWorkder.DoWork += (s, arg) =>
            {
                bgWorkder.ReportProgress(1);
                var result = workFunc(arg.Argument);
                arg.Result = result;
                bgWorkder.ReportProgress(100);
            };
            bgWorkder.RunWorkerAsync(funcArg);
        }

        public Boolean alert(String label,String messageStr) {
            MessageForm m = new MessageForm();
            m.messageBox.Text = messageStr;
            m.titleBox.Text = label;
            m.ShowDialog(this);
            return m.isOK;
        }

    }
}
