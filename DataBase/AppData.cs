using FoldersCreater_WFA.DataBase.Locations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FoldersCreater_WFA.DataBase
{
    public static class AppData
    {
        public static String DEFAULT_FOLDER_PATH = ".FolderCreaterDataResource";
        public static String LOCATIONS_FILE_NAME = ".ObjectLocations.json";


        public static List<String>? Clients { get; set; }
        public static ListLocations? Locations { get; set; }

        public static String GetCountLoc
        { 
            get
            {
                if (Locations == null) return "Null";

                return Locations.Locations.Count.ToString();
            }
        }

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
