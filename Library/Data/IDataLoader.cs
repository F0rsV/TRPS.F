namespace Library.Data
{
    public interface IDataLoader<T>
    {
        T LoadData(string path);
    }
}