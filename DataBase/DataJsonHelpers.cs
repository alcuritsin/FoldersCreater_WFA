using FoldersCreater_WFA.DataBase.Locations;
using System.Text.Encodings.Web;
using System.Text.Json;
using static System.Windows.Forms.Design.AxImporter;
using System.Text.Unicode;

public static class DataJsonHelpers
{
    private static String DEFAULT_FOLDER_PATH = ".FolderCreaterDataResource";
    private static String LOCATIONS_FILE_NAME = ".ObjectLocations.json";

    public static async void LocationsToJSON(ListLocations loc)
    {
        string fileName = DEFAULT_FOLDER_PATH + Path.DirectorySeparatorChar + LOCATIONS_FILE_NAME;

        if (!Directory.Exists(DEFAULT_FOLDER_PATH))
        {
            Directory.CreateDirectory(DEFAULT_FOLDER_PATH);
        }

        JsonSerializerOptions options = new JsonSerializerOptions
        {
            Encoder = JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.Cyrillic),
            WriteIndented = true
            
        };

        using (FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate))
        {
            await JsonSerializer.SerializeAsync<ListLocations>(fs, loc, options);
        }
    }

    public static async void ObjectToJSON(ObjectLocation obj)
    {
        string fileName = DEFAULT_FOLDER_PATH + Path.DirectorySeparatorChar + LOCATIONS_FILE_NAME;

        if (!Directory.Exists(DEFAULT_FOLDER_PATH))
        {
            Directory.CreateDirectory(DEFAULT_FOLDER_PATH);
        }

        JsonSerializerOptions options = new JsonSerializerOptions
        {
            Encoder = JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.Cyrillic),
            WriteIndented = true
        };

        using (FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate))
        {
            await JsonSerializer.SerializeAsync<ObjectLocation>(fs, obj, options);
        }
    }
}