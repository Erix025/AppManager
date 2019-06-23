using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
namespace AppManager
{
    public partial class frm_Main : Form
    {
        public frm_Main()
        {
            InitializeComponent();
        }
        readonly string datapath = Environment.CurrentDirectory + "/Apps.txt";
        List<App> apps = new List<App>();
        private void Frm_Main_Load(object sender, EventArgs e)
        {
            apps = DataEdit.ReadApps(datapath);
            apps.Sort();
            ReFresh();
        }
        private void Frm_Main_Resize(object sender, EventArgs e)    //调整空间位置
        {
            lst_Apps.Height = Height - 100;
            gb_ControlBox.Height = lst_Apps.Height;
            Width = 378;
        }

        private void But_OpenApp_Click(object sender, EventArgs e)
        {
            try
            {
                apps.Find(app => app.Name == lst_Apps.SelectedItem.ToString()).Open();
            }
            catch
            {
                MessageBox.Show("无法打开应用\n请检查路径完整性");
            }
        }

        private void But_AddApp_Click(object sender, EventArgs e)
        {
            frm_Edit frm_Edit = new frm_Edit();
            frm_Edit.ShowDialog();
            if (CommunicateValue.changed_app != null)
            {
                apps.Add(CommunicateValue.changed_app);
                DataEdit.WriteApps(apps, datapath); //保存
                CommunicateValue.changed_app = null;  //重置
                ReFresh();
                apps.Sort();
            }
        }
        private void ReFresh()
        {
            txt_Search.Text = "";
            ReFresh("");//回调重载，刷新界面
        }
        private void ReFresh(string str)
        {
            lst_Apps.Items.Clear();
            List<App> tem = apps.FindAll(app => app.Name.IndexOf(txt_Search.Text,StringComparison.OrdinalIgnoreCase) >= 0);
            foreach (App app in tem)
            {
                lst_Apps.Items.Add(app.Name);
            }
            but_OpenApp.Enabled = false;
            but_DeleteApp.Enabled = false;
            but_EditApp.Enabled = false;
        }
        private void But_DeleteApp_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("是否删除应用" + lst_Apps.SelectedItem.ToString(), "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                apps.Remove(apps.Find(app => app.Name == lst_Apps.SelectedItem.ToString()));
                DataEdit.WriteApps(apps, datapath); //保存
                ReFresh();
                apps.Sort();
            }
        }

        private void Lst_Apps_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lst_Apps.SelectedIndex != -1)
            {
                but_OpenApp.Enabled = true;
                but_DeleteApp.Enabled = true;
                but_EditApp.Enabled = true;
            }
        }

        private void But_EditApp_Click(object sender, EventArgs e)
        {
            int index = apps.FindIndex(app => app.Name == lst_Apps.SelectedItem.ToString());
            frm_Edit frm_Edit = new frm_Edit(apps[index]);
            frm_Edit.ShowDialog();
            if (CommunicateValue.changed_app != null)
            {
                apps[index].Name = CommunicateValue.changed_app.Name;
                apps[index].Path = CommunicateValue.changed_app.Path;
                DataEdit.WriteApps(apps, datapath);
                CommunicateValue.changed_app = null;
                ReFresh();
                apps.Sort();
            }
        }
        private void Txt_Search_TextChanged(object sender, EventArgs e)
        {
            ReFresh(txt_Search.Text);
        }
    }
}
