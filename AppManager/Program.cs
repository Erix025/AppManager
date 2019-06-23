using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppManager
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var mutex = new System.Threading.Mutex(true, "AppManager");
            if (mutex.WaitOne(0, false))
            {
                Application.Run(new frm_Main());
            }
            else
            {
                MessageBox.Show("AppManager已运行！");
                Application.Exit();
            }
        }
    }
}
