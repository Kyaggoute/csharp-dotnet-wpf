using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Phonebook.Model;

namespace Phonebook.providers
{
    public interface IdataProvider
    {
        IEnumerable<Entity> List();
        IEnumerable<Entity> Search(string text);
    }
}
