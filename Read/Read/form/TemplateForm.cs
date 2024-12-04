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
    public partial class TemplateForm : BaseForm
    {
        public TemplateForm()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            this.DoWorkAsync((o) =>
            {
                //开始异步任务
                return null;
            }, null, (r) =>
            {
                //异步任务执行完成后
            });
        }

    }
}
