using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
namespace AppManager
{
    public class App : IComparable<App>
    {
        public string Name { get; set; } 
        public string Path { get; set; }
        public App(){}
        public App(string name, string path)
        {
            Name = name;
            Path = path;
        }
        public void Open()
        {
            Process.Start(Path);
        }
        public int CompareTo(App app)
        {
            if (app != null)
            {
                return Name.CompareTo(app.Name);
            }
            throw new NotImplementedException();
        }
    }
}
