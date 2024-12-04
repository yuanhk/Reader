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
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Read.form
{
    public partial class HotKeyForm : BaseForm
    {
        public HotKeyForm()
        {
            InitializeComponent();
        }


        private void Main_Load(object sender, EventArgs e)
        {
            titleBox.Text = "快捷键";
            //只允许修改按键码
            hotKeyDgv.Columns[0].ReadOnly = true;
            hotKeyDgv.Columns[2].ReadOnly = true;
            this.DoWorkAsync((o) =>
            {
                return HotKey.get();
            }, null, (r) =>
            {
                hotKeyDgv.DataSource = new BindingList<HotKey>(r);
            });
        }

        private void hotKeyDgv_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && hotKeyDgv.SelectedCells.Count == 1)
            {

                String keyCode = Common.toString(hotKeyDgv.SelectedCells[0].Value);
                if (HotKey.updateKeyCode(e.RowIndex, keyCode))
                    showMessage("已成功修改快捷键设置");
                hotKeyDgv.DataSource = new BindingList<HotKey>(HotKey.get());
            }
        }
       

        private void EditingControl_PreviewKeyDownEvent(object sender, PreviewKeyDownEventArgs e)
        {
            e.IsInputKey = true;
            if (e.KeyCode == Keys.Right || e.KeyCode == Keys.Left || e.KeyCode == Keys.Up || e.KeyCode == Keys.Down)
            {
                var tb = (DataGridViewTextBoxEditingControl)sender;
                String keyCode = Common.toString(e.KeyCode);
                if (!HotKeyService.exists(keyCode))
                {
                    showMessage("可用的键位");
                    tb.Text = Common.toString(e.KeyCode);
                }
                else
                {
                    showMessage("该键位不可用");
                    tb.Text = oldText;
                }
                return;
            }
        }

        public void _KeyDown(object sender, KeyEventArgs e)
        {
            var tb = (DataGridViewTextBoxEditingControl)sender;
            tb.Text = "";
            tb.ReadOnly = true;
           
        }
        String oldText = "";
        public void _KeyUp(object sender, KeyEventArgs e)
        {
          
            var tb = (DataGridViewTextBoxEditingControl)sender;
            String keyCode = Common.toString(e.KeyCode);
            if (!HotKeyService.exists(keyCode))
            {
                showMessage("可用的键位");
                tb.Text = Common.toString(e.KeyCode);
            }
            else
            {
                showMessage("该键位不可用");
                tb.Text = oldText;
            }
            tb.ReadOnly = false;
        }

        /// <summary>
        /// 编辑单元格时触发 https://www.cnblogs.com/yume2015/p/3477933.html
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void hotKeyDgv_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (e.Control is DataGridViewTextBoxEditingControl)
            {
                var tb = (DataGridViewTextBoxEditingControl)e.Control;
                oldText = tb.Text;
                tb.KeyDown += _KeyDown;
                tb.PreviewKeyDown += EditingControl_PreviewKeyDownEvent;
                tb.KeyUp += _KeyUp;
            }
        }

        private void hotKeyDgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            hotKeyDgv.BeginEdit(false);
        }

        private void hotKeyDgv_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void 全部重置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HotKey.reset();
            hotKeyDgv.DataSource = new BindingList<HotKey>(HotKey.get());
        }


    }


}
