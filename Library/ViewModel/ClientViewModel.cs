using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;


namespace Library.ViewModel
{
    public class ClientViewModel : INotifyPropertyChanged
    {
        private readonly Data.IUnitOfWork unit;

        public ObservableCollection<Model.Client> ListOfSearchedClients { get; set; }

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
        
        private Model.Client selectedClient;
        public Model.Client SelectedClient
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
                        List<Model.Client> searchedList = new List<Model.Client>();

                        if (ClientSearchFilter == "за номером читацького квитка")
                        {
                            searchedList = unit.ClientRepository.FindById(ClientSearchInput);
                        }
                        else if (ClientSearchFilter == "за ПІБ")
                        {
                            searchedList = unit.ClientRepository.FindByName(ClientSearchInput);
                        }

                        searchedList.ForEach(x => ListOfSearchedClients.Add(x));
                    });
            }
        }



        public ClientViewModel(Data.IUnitOfWork unit)
        {
            this.unit = unit;

            ListOfSearchedClients = new ObservableCollection<Model.Client>();
        }


        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}