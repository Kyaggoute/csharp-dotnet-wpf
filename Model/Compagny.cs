using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook.Model
{
    public class Compagny : Entity
    {
        public string Name { get; set; }
        

        public Compagny(int id, string name) : base(id)
        {
            Name = name;
        }
        public override string ToString()
        {
            return Id + ":" + Name ;
        }
    }
   
}
