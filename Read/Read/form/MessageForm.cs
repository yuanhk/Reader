using Read.plugin;
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
    public partial class MessageForm : BaseForm
    {

        public Boolean isOK = false;

        public MessageForm()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            titleBox.Text = "提示";
            this.messageBox.MouseDown += cannot_getFocus;
        }

        private void buttonEx1_Click(object sender, EventArgs e)
        {
            isOK = "确定".Equals(((ButtonEx)sender).text);
            this.Close();
        }

        private void tipLabel_Click(object sender, EventArgs e)
        {

        }

    }
}
