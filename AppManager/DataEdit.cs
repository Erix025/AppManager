using Index.DataEdit;
using System.Collections.Generic;
namespace AppManager
{
    class DataEdit
    {
        public static List<App> ReadApps(string path)   //读取Applist
        {
            var result = new List<App>();
            var input = ReadFiles.ItemRead(path,true);
            foreach (var items in input)
            {
                var app = new App();
                foreach (var item in items)
                {
                    switch (item.Key)
                    {
                        case "name":
                            app.Name = item.Value;
                            break;
                        case "path":
                            app.Path = item.Value;
                            break;
                    }
                }
                result.Add(app);
            }
            return result;
        }
        public static void WriteApps(List<App> apps, string path)   //写入Applist
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
