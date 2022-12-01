using FoldersCreater_WFA.DataBase;
using FoldersCreater_WFA.DataBase.Locations;

namespace FoldersCreater_WFA
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());

            DataJsonHelpers.LocationsFromJSON(); //Заполняю поле данными...

            MessageBox.Show(string.Format("Count: {0}", AppData.GetCountLoc)); //Тут поле пустое == null
            

        }


    }
}