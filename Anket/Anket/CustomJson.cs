using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.Threading.Tasks;

namespace Anket
{
    internal class CustomJson
    {
        public static void Save<T>(T data, string fileName)
        {
            JsonSerializerOptions options = new JsonSerializerOptions
            {
                WriteIndented = true
            };

            string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string filePath = Path.Combine(documentsPath, fileName + ".json");

            // Now, you can save the file to the chosen directory.
            File.WriteAllText(filePath, JsonSerializer.Serialize(data, options));
        }


        public static T? Load<T>(string fileName) where T : new()
        {
            T? loadedData = new T();
            JsonSerializerOptions options = new JsonSerializerOptions();
            options.WriteIndented = true;

            string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string filePath = Path.Combine(documentsPath, fileName + ".json");

            using FileStream stream = new FileStream(filePath, FileMode.OpenOrCreate);

            if (stream.Length != 0)
            {
                loadedData = JsonSerializer.Deserialize<T>(stream, options);
            }

            return loadedData;
        }
    }
}
