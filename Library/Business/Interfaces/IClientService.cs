using System.Collections.Generic;

namespace Library.Business
{
    public interface IClientService
    {
        List<Model.Client> FindById(string id);
        List<Model.Client> FindByName(string name);

    }
}