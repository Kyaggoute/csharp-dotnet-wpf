using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
using Phonebook.ViewModels;

namespace Phonebook.Views
{
    /// <summary>
    /// Logique d'interaction pour Contacts.xaml
    /// </summary>
    public partial class Contacts : UserControl
    {

        public Contacts()
        {
            InitializeComponent();
        }

        public void List_Click(object sender, RoutedEventArgs e)

        {
            (DataContext as ContactsViewModel).Execute_List();
        }

        public void Search_Click(object sender, RoutedEventArgs e)
        {
            (DataContext as ContactsViewModel).Execute_Search();
        }
    }


}
