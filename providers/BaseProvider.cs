using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Phonebook.Model;
using System.Windows.Documents;
using MySql.Data.MySqlClient;

namespace Phonebook.providers
{
    public abstract class BaseProvider : IdataProvider
    {
        protected abstract string GetTable();
        protected abstract Entity CreatItem(MySqlDataReader reader);

        protected IEnumerable<Entity> GetData()
        //override:remplacer une methode qui existe dans la classe parent
        {
            // Entity p1 = new Person(1, "Sophie", "Lozofy");
            //Entity p2 = new Person(2, " Annie", "Versaire");
            //Entity p3 = new Person(3, "Paul", "Ochon");

            //eturn new List<Entity>() { p1, p2, p3 };

            string connectionstring = "server=localhost;port=3306;user=root;password=;database=adodotnet";
            MySqlConnection connection = new MySqlConnection(connectionstring);

            connection.Open();

            //pas commun au deux providers
            MySqlCommand command = new MySqlCommand("SELECT * FROM " + GetTable(), connection);

            MySqlDataReader reader = command.ExecuteReader();

            List<Entity> results = new List<Entity>();
            while (reader.Read())
            {
                //pas en commun
                Entity item = CreatItem(reader);
                results.Add(item);
            }
            connection.Close();

            return results;

        }
        public IEnumerable<Entity> List()
        {
            return GetData();
            
        }
        public IEnumerable<Entity> Search(string text)
        {
            string search = text.ToLower();
            List<Entity> results = new List<Entity>();
            
            foreach (Entity item in GetData())
            {
                //passer en string les item + les passer en lowercase + voir qui correspond au recherche
                if (item.ToString().ToLower().Contains(search))
                {
                    results.Add(item);
                }
            }
            return results;

        }


    }
}

