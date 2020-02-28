using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Library.Model;

namespace Library.ViewModel
{
    public class ClientViewModel : INotifyPropertyChanged
    {
        public List<Client> ListOfClients { get; set; }
        public ObservableCollection<Client> ListOfSearchedClients { get; set; }

        private string clientSearchFilter;
        public string ClientSearchFilter
        {
            get => clientSearchFilter;
            set
            {
                //change maybe to dict
                clientSearchFilter = value;
                OnPropertyChanged("ClientSearchFilter");
            }
        }

        private string clientSearchInput;
        public string ClientSearchInput
        {
            get => clientSearchInput;
            set
            {
                clientSearchInput = value;
                OnPropertyChanged("ClientSearchInput");
            }
        }
        
        private Client selectedClient;
        public Client SelectedClient
        {
            get => selectedClient;
            set
            {
                selectedClient = value;
                OnPropertyChanged("SelectedClient");
            }
        }


        private RelayCommand findClientCommand;
        public RelayCommand FindClientCommand
        {
            get
            {
                return findClientCommand ??= new RelayCommand(obj =>
                    {
                        ListOfSearchedClients.Clear();
                        List<Client> searchedList = new List<Client>();

                        if (ClientSearchFilter == "за номером читацького квитка")
                        {
                            searchedList = ListOfClients.FindAll(x => x.LibraryCardId == Convert.ToInt32(ClientSearchInput));
                        }
                        else if (ClientSearchFilter == "за ПІБ")
                        {
                            searchedList = ListOfClients.FindAll(x => x.Name == ClientSearchInput);
                        }

                        searchedList.ForEach(x => ListOfSearchedClients.Add(x));
                    },
                    obj => true); //СДЕЛАТЬ ВАЛІДЕЙШ
            }
        }




        public ClientViewModel()
        {
            ListOfClients = new List<Client>();
            ListOfSearchedClients = new ObservableCollection<Client>();
        }


        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}