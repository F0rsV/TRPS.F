using System.Collections.Generic;

namespace Library.Data
{
    public interface IRepository<T>
    {
        IEnumerable<T> GetAll();
    }
}