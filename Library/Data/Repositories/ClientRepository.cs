using System.Collections.Generic;
using System.Linq;

namespace Library.Data
{
    public class ClientRepository : IRepository<Model.Client>
    {
        private LibraryContext context;

        public ClientRepository(LibraryContext context)
        {
            this.context = context;
        }

        public IEnumerable<Model.Client> GetAll()
        {
            return context.Clients.ToList();
        }
    }
}