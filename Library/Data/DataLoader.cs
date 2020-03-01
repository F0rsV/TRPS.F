using System;
using  Library.Model;

namespace Library.Data
{
    public class DataLoader<T> : IDataLoader<T>
    {
        private ISerializer<T> serializer;

        public T LoadData(string path)
        {
            if (path.EndsWith(".json"))
            {
                serializer = new JsonSerializer<T>();
                return serializer.Deserialize(path);
            }

            T t = (T)new object();
            return t;
        }
    }
}