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


        public Client FindClient(int libraryCardIdSearch)
        {
            return ListOfClients.Find(x => x.LibraryCardId == libraryCardIdSearch);
        }

        public List<Client> FindClient(string nameSearch)
        {
            return ListOfClients.FindAll(x => x.Name == nameSearch);
        }

        /*
            ПИТАННЯ ВИКЛАДАЧУ

            Метод GetBooksThatClientHas() краще реалізувати у класі:
            a) ClientManager (в якості аргумента буде передаватись екзмпляр класу Client)
            b) Client (тоді, в якості аргументу не потрібно буде передавати нічого)
        */

        public List<Book> GetBooksThatClientHas(Client client)
        {
            return client.BooksList;
        }
    }
}