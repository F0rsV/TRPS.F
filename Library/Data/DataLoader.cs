using  Library.Model;

namespace Library.Data
{
    public class DataLoader : IDataLoader
    {
        public object LoadData(string path)
        {
            LibraryManager libraryManager = new LibraryManager();


            Book book1 = new Book("Shrek", new Author("Forsiuk"), BookTheme.Fiction, 0);
            Book book2 = new Book("ToyStory", new Author("Pavlenko"), BookTheme.Romance, 1);

            Client client1 = new Client(0, "Chen", 20203050);
            Client client2 = new Client(1, "Ryi", 10203040);

            client1.BooksList.Add(book1);


            libraryManager.BookViewModel.ListOfBooks.Add(book1);
            libraryManager.BookViewModel.ListOfBooks.Add(book2);

            libraryManager.ClientViewModel.ListOfClients.Add(client1);
            libraryManager.ClientViewModel.ListOfClients.Add(client2);


            return libraryManager;
        }
    }
}