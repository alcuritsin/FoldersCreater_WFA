using FoldersCreater_WFA.DataBase.Locations;
using System.Text.Encodings.Web;
using System.Text.Json;
using static System.Windows.Forms.Design.AxImporter;
using System.Text.Unicode;
using FoldersCreater_WFA.DataBase;

public static class DataJsonHelpers
{
    public static async void LocationsToJSON(ListLocations loc)
    {
        string fileName = AppData.DEFAULT_FOLDER_PATH + Path.DirectorySeparatorChar + AppData.LOCATIONS_FILE_NAME;

        if (AppData.Locations == null) return;

        if (!Directory.Exists(AppData.DEFAULT_FOLDER_PATH))
        {
            Directory.CreateDirectory(AppData.DEFAULT_FOLDER_PATH);
        }

        JsonSerializerOptions options = new JsonSerializerOptions
        {
            Encoder = JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.Cyrillic),
            WriteIndented = true
            
        };

        using (FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate))
        {
            await JsonSerializer.SerializeAsync<ListLocations>(fs, AppData.Locations, options);
        }
    }

    public static async void LocationsFromJSON()
    {
        String fileName = AppData.DEFAULT_FOLDER_PATH + Path.DirectorySeparatorChar + AppData.LOCATIONS_FILE_NAME;

        //ListLocations? locations = new ListLocations();

        using (FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Read))
        {
            AppData.Locations = await JsonSerializer.DeserializeAsync<ListLocations>(fs);
            //ListLocations? loc = await JsonSerializer.DeserializeAsync<ListLocations>(fs);
            //Console.WriteLine(loc.Locations.Count.ToString());
        }
    }    
}