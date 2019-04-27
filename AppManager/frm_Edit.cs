using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace AppManager
{
    public partial class frm_Edit : Form
    {
        public frm_Edit()
        {
            InitializeComponent();
            Text = "创建应用";
        }
        public frm_Edit(App app)
        {
            InitializeComponent();
            Text = "编辑应用[" + app.Name + "]";
            txt_Name.Text = app.Name;
            txt_Path.Text = app.Path;
        }

        private void But_Preview_Click(object sender, EventArgs e)
        {
            ofd_Main.ShowDialog();
            txt_Name.Text = Path.GetFileNameWithoutExtension(ofd_Main.FileName);
            txt_Path.Text = ofd_Main.FileName;
        }

        private void But_Confirm_Click(object sender, EventArgs e)
        {
            if (txt_Name.Text != "" && txt_Path.Text != "")
            {
                CommunicateValue.changed_app = new App(txt_Name.Text, txt_Path.Text);
                Dispose();
            }
            else
            {
                MessageBox.Show("参数为空");
            }
        }

        private void But_Canel_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
