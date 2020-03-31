using System.Collections.Generic;

namespace Library.Data
{
    public interface IClientRepository
    {
        List<Model.Client> FindById(string id);
        List<Model.Client> FindByName(string name);
    }
}