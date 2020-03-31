using System;
using System.Collections.Generic;
using System.Linq;

namespace Library.Data
{
    public class ClientRepository : IClientRepository
    {
        private readonly LibraryContext context;

        public ClientRepository(LibraryContext context)
        {
            this.context = context;
        }

        public List<Model.Client> FindById(string id)
        {
            int searchId = -1;
            if (!string.IsNullOrEmpty(id) && id.All(char.IsDigit))
            {
                searchId = Convert.ToInt32(id);
            }

            return context.Clients.ToList().FindAll(x => x.Id == searchId);
        }

        public List<Model.Client> FindByName(string name)
        {
            return context.Clients.ToList().FindAll(x => x.Name == name);
        }

    }
}