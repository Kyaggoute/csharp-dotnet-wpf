using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Phonebook.Model;
using Phonebook.providers;

namespace Phonebook.Services
{
    public class RepositoryService
    {
        //readonly pas amenée à changer 
        private readonly IEnumerable<IdataProvider> _providers;

        //private IEnumerable providers;

        public RepositoryService(IEnumerable<IdataProvider> providers)
        {
            this._providers = providers;
        }

        public IEnumerable<Entity> List()
        {
            IEnumerable<Entity> accu = new List<Entity>();
            foreach (IdataProvider element in _providers)
            {
                accu = accu.Concat(element.List());
            }
            return accu;
        }
        public IEnumerable<Entity> Search(string text)
        {   
            IEnumerable<Entity> accu = new List<Entity>();
            foreach (IdataProvider element in _providers)
            {
                accu = accu.Concat(element.Search(text));
            }
            return accu;
        }


    }
}
