using System;
using System.Collections.Generic;

namespace Library.Model
{
    public class ClientManager
    {
        public List<Client> ListOfClients { get; set; }

        public ClientManager()
        {
            ListOfClients = new List<Client>();
        }


        public List<Client> FindClients(int libraryCardId)
        {
            return ListOfClients.FindAll(x => x.LibraryCardId == libraryCardId);
        }

        public List<Client> FindClients(string name)
        {
            return ListOfClients.FindAll(x => x.Name == name);
        }


    }
}