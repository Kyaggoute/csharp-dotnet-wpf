using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Phonebook.Model;
using Phonebook.providers;
using Phonebook.Services;
using Phonebook.ViewModels;

namespace Phonebook
{

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly AboutViewModel _AboutViewModel;
        private readonly ContactsViewModel _ContactsViewModel;

        
        public MainWindow()
        {
            IdataProvider jose = new PersonProvider();
            IdataProvider sophie = new CompagnyProvider();
            IEnumerable<IdataProvider> providers = new List<IdataProvider>() {jose, sophie};

            RepositoryService bertrand = new RepositoryService(providers);

            _AboutViewModel = new AboutViewModel();
            _ContactsViewModel = new ContactsViewModel( bertrand);

            InitializeComponent();
        }
       // public void executerPrg(object sender, RoutedEventArgs e)

        //{
            //IdataProvider jose = new PersonProvider();
            //IdataProvider sophie = new CompagnyProvider();
            //IEnumerable<IdataProvider> providers = new List<IdataProvider>() {jose, sophie};

            //RepositoryService bertrand = new RepositoryService(providers);

            //IEnumerable<Entity> result = bertrand.List();

            //MessageBox.Show(JsonSerializer.Serialize(result));
       // }
        public void About_Click(object sender, RoutedEventArgs e)

        {
            DataContext = _AboutViewModel; 
        }
        public void Contacts_Click(object sender, RoutedEventArgs e)

        {
            DataContext = _ContactsViewModel;
        }
    }
}
