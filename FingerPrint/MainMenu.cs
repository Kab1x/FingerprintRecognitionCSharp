using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace FingerPrint
{
   
    public partial class Accueil : Form
    {
        public static MySqlConnection mySqlConInstance;
        public static int res;
        public Accueil()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            statusLabel.Text = "Connexion en cours...";
            res = OpenConnectionToDB();
            UpdateUI(res);
        }

        private void connectToDb_Click(object sender, EventArgs e)
        {
            if (res == 1)
            {
                FormulairInfoForm newWindow = new FormulairInfoForm();
                newWindow.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Problème de liason à la base de données");
                res = OpenConnectionToDB();
                UpdateUI(res);
            }
        }

        private void UpdateUI(int res)
        {
            if (res == 1) //if successfuly opened the DB;
            {
                statusLabel.Text = "Connection établie a la base de données.";
                statusLed.BackColor = Color.Green;

            }
            else
            {
                statusLabel.Text = "Impossible d'établir une connexion a la base de donnée";
                statusLed.BackColor = Color.Red;
            }
        }
        private int OpenConnectionToDB()
        {
            string connectionString = "datasource=localhost; username=root; password=; database=fingerprints";
            MySqlConnection con = new MySqlConnection(connectionString);
            try
            {
                con.Open();
                mySqlConInstance = con;
            }
            catch (Exception e)
            {
                MessageBox.Show("ERROR: \nStatus de connexion " + e.ToString());
                return 0;
            }
            return 1;
        }
    }
}
