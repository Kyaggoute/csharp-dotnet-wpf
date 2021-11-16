using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook.Model
{
    public class Person : Entity
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }

        public Person(int id, string firstname, String lastname): base(id)
        {
            Firstname = firstname;
            Lastname = lastname;
        }
        public override string ToString()
        {
            return Id +":"+Firstname+":"+Lastname;
        }
    }
}
