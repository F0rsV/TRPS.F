using System.Windows;

namespace Library.View
{
    /// <summary>
    /// Логика взаимодействия для BaseWindow.xaml
    /// </summary>
    public partial class BaseWindow : Window
    {
        public BaseWindow()
        {
            Configs.ViewModelCreator viewModelCreator = new Configs.ViewModelCreator();
            DataContext = viewModelCreator.Create();

            InitializeComponent();
        }
    }
}
