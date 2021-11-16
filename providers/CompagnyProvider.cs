using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Phonebook.Model;

namespace Phonebook.providers
{
    public class CompagnyProvider : BaseProvider
    {
        protected override string GetTable()
        {
            return "compagny";
        }

        protected override Entity CreatItem(MySqlDataReader reader)
        {
            return new Compagny(Convert.ToInt32(reader["id"]), reader["name"].ToString());
        }
       
    }


}
