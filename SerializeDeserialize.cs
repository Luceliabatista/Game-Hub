using Newtonsoft.Json;
using System.Net.Http.Json;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json;
using static GameHub.Register;

namespace GameHub
{
    static class SerializeDeserialize
    {
        public static List<T> Read<T>(string fileName )
        {
            //Deserializando
            string text = System.IO.File.ReadAllText(fileName);
            return JsonConvert.DeserializeObject<List<T>>(text);
        }

        public static void Write<T>(string fileName, T data)
        {
            List<T> Query = Read<T>(fileName);

            if (Query == null) Query = new();
            Query.Add(data);

            var options = new JsonSerializerOptions { WriteIndented = true };
            //Serializando
            string jsonString = System.Text.Json.JsonSerializer.Serialize(Query, options);
            File.WriteAllText(fileName, jsonString);
        }
    }
}
