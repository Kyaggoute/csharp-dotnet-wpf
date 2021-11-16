using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Phonebook.Model;
using Phonebook.Services;

namespace Phonebook.ViewModels
{
    public class ContactsViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
    
        public IEnumerable<String> Results { get; set; }
        private readonly RepositoryService _repositoryService;
        public string SearchText { get; set; }

        public ContactsViewModel(RepositoryService repositoryService)
        {
            _repositoryService = repositoryService;
            Results = new List<String>(){ "Bonjour", "comment", "ca", "va" };
            SearchText = "";
        }
        public void Execute_List()
        {
            //_repositoryService équivalent à bertrand 
            IEnumerable<Entity> results = _repositoryService.List();
            Results= results.Select(x=>x.ToString());
            //this: ViewModel
            PropertyChanged(this, new PropertyChangedEventArgs("Results"));
        }
        public void Execute_Search ()
        {
            IEnumerable<Entity> results = _repositoryService.Search(SearchText);
            Results = results.Select(x=>x.ToString());
            PropertyChanged(this, new PropertyChangedEventArgs("Results"));
            SearchText = "";
            PropertyChanged(this, new PropertyChangedEventArgs(SearchText));
        }

    }
}
