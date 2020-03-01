using System;
using System.IO;
using Newtonsoft.Json;

namespace Library.Data
{
    public class JsonSerializer<T> : ISerializer<T>
    {
        public void Serialize(T obj, string path)
        {
            using StreamWriter file = File.CreateText(path);
            JsonSerializerSettings settings = new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.All,
            };
            JsonSerializer serializer = JsonSerializer.Create(settings);

            serializer.Serialize(file, obj);
        }

        public T Deserialize(string path)
        {
            using StreamReader file = File.OpenText(path);
            JsonReader jsonReader = new JsonTextReader(file);

            JsonSerializerSettings settings = new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.All
            };
            JsonSerializer serializer = JsonSerializer.Create(settings);

            return serializer.Deserialize<T>(jsonReader);
        }
    }
}