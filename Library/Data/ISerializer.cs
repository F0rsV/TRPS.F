namespace Library.Data
{
    public interface ISerializer<T>
    {
        void Serialize(T obj, string path);
        T Deserialize(string path);
    }
}