using DataEdit;
using System.Collections.Generic;
namespace AppManager
{
    class DataEdit
    {
        public static List<App> ReadApps(string path)
        {
            var result = new List<App>();
            var input = ReadFiles.ItemRead(path);
            string[] keys = input.Item2;
            string[] values = input.Item3;
            int i = 0;
            string name = "";
            foreach (string key in keys)
            {
                switch (key)
                {
                    case "name":
                        name = values[i];
                        break;
                    case "path":
                        result.Add(new App(name, values[i]));
                        break;
                }
                i++;
            }
            return result;
        }
        public static void WriteApps(List<App> apps, string path)
        {
            string[] result = new string[apps.Count * 3];
            int i = 0;
            foreach (App app in apps)
            {
                result[i * 3] = "[" + app.Name + "]";
                result[i * 3 + 1] = "name=" + app.Name;
                result[i * 3 + 2] = "path=" + app.Path;
                i++;
            }
            WriteFiles.Write(result, path);
        }
    }
}
