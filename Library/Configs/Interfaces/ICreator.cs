namespace Library.Configs
{
    public interface ICreator<T>
    {
        T Create();
    }
}