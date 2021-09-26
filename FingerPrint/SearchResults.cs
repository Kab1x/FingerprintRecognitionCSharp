using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace FingerPrint
{
    public partial class SearchResults : Form
    {
        MySqlConnection con = new MySqlConnection(Accueil.connectionString);

        Dictionary<int, Personne> personnes = new Dictionary<int, Personne>();

        private int fingerIndex = -1;
        private int foundId = -1;
        
        public SearchResults()
        {
            InitializeComponent();
        }

        public int InitSearch(int endings, int bifurcations)
        {
            StartDbSearch(endings, bifurcations);
            int id = GetPersonIdWithMinutiae(endings, bifurcations, out fingerIndex);
            if (id == -1)
            {
                MessageBox.Show("Aucune personne ne correspont a l'empreinte chargée");
                return id; 
            }
            else
            {
                foundId = id;
            }
            return id;
        }


        private void StartDbSearch(int endings, int bifurcations)
        {
            OpenDbConnection();
            if (con.State == ConnectionState.Open)
            {
                string sql = "SELECT userId, dataString FROM empreintes";
                MySqlCommand cmd= new MySqlCommand(sql,con);
                MySqlDataReader myReader;
                myReader = cmd.ExecuteReader();
                while (myReader.Read())
                {
                    AddPerson(myReader.GetInt32(0), myReader.GetString(1));
                }
            }
        }

        public int GetPersonIdWithMinutiae(int e, int b, out int finger)
        {
            int result = -1;
            foreach (Personne p in personnes.Values)
            {
                result = p.hasPrints(e, b);
                if (result != -1)
                {
                    finger = result;
                    return p.id;
                }
            }
            finger = -1;
            return -1;
        }

        private void AddPerson(int id, string data)
        {
            Personne p = new Personne(id,data);
            personnes.Add(id, p);
        }

        void OpenDbConnection()
        {
            try
            {
                con.Open();
            }
            catch (Exception ex1)
            {
                MessageBox.Show(ex1.ToString());
            }
        }

        string[] fingersNames = {   
                                    "l'Auriculaire Gauche", 
                                    "l'Annulaire Gauche", 
                                    "le Majeur Gauche",
                                    "l'Index Gauche",
                                    "le Pouce Gauche",
                                    "le Pouce Droite",
                                    "l'Index Droite",
                                    "le Majeur Droite",
                                    "l'Annulaire Droite",
                                    "l'Auriculaire Droite",
                                };

        private void SearchResults_Load(object sender, EventArgs e)
        {
            UpdateLabels();

        }

        private void UpdateLabels()
        {
            mainTextLabel.Text = "Correspondance d'empreinte trouvé avec: " + personnes[foundId].nom + " " +
                     personnes[foundId].prenom + " dans " + fingersNames[fingerIndex];

            nomLabel.Text = "Nom: " + personnes[foundId].nom;
            prenomLabel.Text = "Prenom: " + personnes[foundId].prenom;
            dateNaissanceLabel.Text = "Date de Naissance: " + personnes[foundId].dateNaissance;
            lieuNaissanceLabel.Text = "Lieu de Naissance: " + personnes[foundId].lieuNaissance;
            sexeLabel.Text = "Sexe: " + personnes[foundId].sexe;
            adresseLabel.Text = "Adresse: " + personnes[foundId].adresse;
            MemoryStream ms = new MemoryStream(personnes[foundId].profilePicture);
            photoProfile.Image = Image.FromStream(ms);
        }
    }
}
