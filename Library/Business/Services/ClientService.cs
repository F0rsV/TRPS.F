using System.Collections.Generic;
using System.Linq;
using Library.Model;

namespace Library.Business
{
    public class ClientService : IClientService
    {
        private readonly Data.IUnitOfWork unit;

        public ClientService(Data.IUnitOfWork unit)
        {
            this.unit = unit;
        }

        public List<Client> FindById(int id)
        {
            return unit.ClientRepository.GetAll().ToList().FindAll(x => x.Id == id);
        }

        public List<Client> FindByName(string name)
        {
            return unit.ClientRepository.GetAll().ToList().FindAll(x => x.Name == name);
        }
    }
}