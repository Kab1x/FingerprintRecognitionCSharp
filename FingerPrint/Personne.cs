using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace FingerPrint
{
    public class Personne
    {
        public string nom, prenom, dateNaissance, lieuNaissance, sexe, adresse;
        public byte[] profilePicture;

        public int id { get; }

        int[,] minutiae = new int[10, 2];

        public Personne(int id, string dataString)
        {
            this.id = id;
            FillMinutiae(dataString);
        }

        public Personne(int id)
        {
            this.id = id;
            FetchRestData();
        }

        public int hasPrints(int ends, int bif)
        {
            for (int i = 0; i < 10; i++)
            {
                if (minutiae[i, 0] == ends && bif == minutiae[i, 1])
                {
                    FetchRestData();
                    return i;
                }
            }
            return -1;
        }

        public void FillMinutiae(string dataString)
        {
            string[] subStrings = dataString.Split('\n');
            int i = 0;
            foreach (var sub in subStrings)
            {
                if(i % 2 == 0)
                {
                    minutiae[i/2, 0] = int.Parse(sub);
                }
                else
                {
                    minutiae[i/2, 1] = int.Parse(sub);
                }
                i++;
            }
        }
        public void FetchRestData() 
        {
            MySqlConnection con = new MySqlConnection(Accueil.connectionString);
            con.Open();
            string sql = "SELECT * FROM `personne` WHERE ID=" + id.ToString()+";";
            MySqlDataReader reader = new MySqlCommand(sql, con).ExecuteReader();

            reader.Read();
            
            this.nom = reader.GetString(1);
            this.prenom = reader.GetString(2);
            this.dateNaissance = reader.GetString(3);
            this.dateNaissance = this.dateNaissance.Split(' ')[0];
            this.lieuNaissance = reader.GetString(4);
            this.sexe = reader.GetString(5);
            this.adresse = reader.GetString(6);
            
            var length = reader.GetBytes(7, 0, null, 0, 0);
            profilePicture = new byte[length];
            reader.GetBytes(7, 0, profilePicture, 0, (int)length);

        }
    }
}
