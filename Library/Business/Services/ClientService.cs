using System;
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

        public List<Client> FindById(string id)
        {
            int searchId = -1;
            if (!string.IsNullOrEmpty(id) && id.All(char.IsDigit))
            {
                searchId = Convert.ToInt32(id);
            }

            return unit.ClientRepository.GetAll().ToList().FindAll(x => x.Id == searchId);

        }

        public List<Client> FindByName(string name)
        {
            return unit.ClientRepository.GetAll().ToList().FindAll(x => x.Name == name);
        }
    }
}