using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Library.Data;
using Library.Model;



namespace Library.View
{
    /// <summary>
    /// Логика взаимодействия для BaseWindow.xaml
    /// </summary>
    public partial class BaseWindow : Window
    {
        private LibraryManager libraryManager;
        private IDataLoader dataLoader;

        public BaseWindow()
        {
            dataLoader = new DataLoader();
            libraryManager = (LibraryManager)dataLoader.LoadData();

            InitializeComponent();
        }

    }
}
