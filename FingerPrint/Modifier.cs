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
    public partial class Modifier : Form
    {
        private Dictionary<int, Personne> personnes;

        public Modifier()
        {
            InitializeComponent();
        }

        private void FetchAllPersons()
        {
            personnes = new Dictionary<int, Personne>();
            MySqlConnection myCon = new MySqlConnection(Accueil.connectionString);
            myCon.Open();
            string sql = "SELECT ID FROM personne";
            MySqlCommand cmd = new MySqlCommand(sql, myCon);
            MySqlDataReader rdr = cmd.ExecuteReader();
            
            while (rdr.Read())
            {
                int _id = rdr.GetInt32(0);
                personnes.Add(_id, new Personne(_id));
            }
        }
        private void FillTable()
        {
            FetchAllPersons();
            dataTable.Rows.Clear();

            List<int> myKeys = personnes.Keys.ToList();
            for (int i = 0; i < personnes.Count; i++)
            {
                DataGridViewButtonCell dgvbc = new DataGridViewButtonCell();
                dataTable.Rows.Add();
                dataTable.Rows[i].Cells[0].Value = personnes[myKeys[i]].id;
                dataTable.Rows[i].Cells[1].Value = personnes[myKeys[i]].nom;
                dataTable.Rows[i].Cells[2].Value = personnes[myKeys[i]].prenom;
                dataTable.Rows[i].Cells[3].Value = personnes[myKeys[i]].dateNaissance;
                dataTable.Rows[i].Cells[4].Value = personnes[myKeys[i]].lieuNaissance;
                dataTable.Rows[i].Cells[5].Value = personnes[myKeys[i]].sexe;
                dataTable.Rows[i].Cells[6].Value = personnes[myKeys[i]].adresse;
                MemoryStream ms = new MemoryStream(personnes[myKeys[i]].profilePicture);
                dataTable.Rows[i].Cells[7].Value = Image.FromStream(ms);
                ms.Close();

                dataTable.Rows[i].Cells[8].Value = "Supprimer";
                dataTable.Rows[i].Cells[9].Value = "Modifier";
            }
        }
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            Application.Exit();
        }
        private void Modifier_Load(object sender, EventArgs e)
        {
            FillTable();
        }

        private void dataTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int x = e.ColumnIndex;
            int y = e.RowIndex;
            int selectedID = int.Parse(dataTable[0, y].Value.ToString());

            if(x == 8) //SUPRIMER
            {
                DialogResult dialogResult = MessageBox.Show("êtes-vous sûr de vouloir supprimer " + personnes[selectedID].nom + " " + personnes[selectedID].prenom, "Attention!", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    MySqlConnection mycon = new MySqlConnection(Accueil.connectionString);
                    mycon.Open();
                    string sql = "DELETE FROM `personne` WHERE id=" + selectedID + ";";
                    MySqlCommand cmd = new MySqlCommand(sql, mycon);
                    cmd.ExecuteNonQuery();
                    dataTable.Rows.Remove(dataTable.Rows[y]);
                    personnes.Remove(selectedID);
                }
            }
            if(x == 9) //Modifier
            {
                FormulairInfoForm fif = new FormulairInfoForm(personnes[selectedID]);
                
                fif.ShowDialog();
                personnes[selectedID].FetchRestData();
                FillTable();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormulairInfoForm fif = new FormulairInfoForm();
            fif.ShowDialog();
            FillTable();
        }
    }
}
