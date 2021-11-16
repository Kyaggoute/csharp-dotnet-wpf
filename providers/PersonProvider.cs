using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using MySql.Data.MySqlClient;
using Phonebook.Model;

namespace Phonebook.providers
{
    public class PersonProvider : BaseProvider
    {
        protected override string GetTable()
        {
            return "person";
        }
        protected override Entity CreatItem(MySqlDataReader reader)
        {
            return new Person(Convert.ToInt32(reader["id"]), reader["firstname"].ToString(), reader["lastname"].ToString());
        }
        
        

    }
    

    
    
}