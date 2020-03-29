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
        private readonly Business.IClientService clientService;

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
                            searchedList = clientService.FindById(ClientSearchInput);
                        }
                        else if (ClientSearchFilter == "за ПІБ")
                        {
                            searchedList = clientService.FindByName(ClientSearchInput);
                        }

                        searchedList.ForEach(x => ListOfSearchedClients.Add(x));
                    });
            }
        }



        public ClientViewModel(Business.IClientService clientService)
        {
            this.clientService = clientService;

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