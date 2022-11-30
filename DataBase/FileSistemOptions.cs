using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoldersCreater_WFA.DataBase
{
    public static class FileSistemOptions
    {
        public static List<String> GetListFolders(String path = "*")
        {
            String currentPath = Environment.CurrentDirectory;
            if (path != "*") currentPath = path;

            List<String> folders = new List<String>();

            // Make a reference to a directory.
            DirectoryInfo di = new DirectoryInfo(currentPath);

            // Get a reference to each directory in that directory.
            DirectoryInfo[] diArr = di.GetDirectories();

            // Display the names of the directories.
            foreach (DirectoryInfo dri in diArr)
                folders.Add(dri.Name);

            return folders;
        }
    }
}
