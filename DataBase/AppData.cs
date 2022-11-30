using FoldersCreater_WFA.DataBase.Locations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FoldersCreater_WFA.DataBase
{
    public static class AppData
    {
        public static List<String> Clients { get; set; }
        public static ListLocations Locations { get; set; }

        public static string VersionApp
        {
            get
            {
                var ver = Assembly.GetExecutingAssembly().GetName().Version;
                return string.Format("Product Name: {4}, Version: {0}.{1}.{2}.{3}", ver.Major, ver.Minor, ver.Build, ver.Revision, Assembly.GetEntryAssembly().GetName().Name);
            }
        }
    }
}
