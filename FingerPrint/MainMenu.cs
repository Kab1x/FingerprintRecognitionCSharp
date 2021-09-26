using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace FingerPrint
{
    public partial class Accueil : Form
    {
        public static string connectionString = "datasource=localhost; username=root; password=; database=fingerprints";
        public static MySqlConnection con;
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
                (new Modifier()).Show();
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
            
            con = new MySqlConnection(connectionString);
            try
            {
                con.Open();
                mySqlConInstance = con;
            }
            catch (Exception _)
            {
                return 0;
            }
            return 1;
        }

        private void matchingClick_Click(object sender, EventArgs e)
        {
            if (res == 1)
            {
                MatchingForm mf = new MatchingForm();
                mf.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Problème de liason à la base de données");
                res = OpenConnectionToDB();
                UpdateUI(res);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Print2Print p2p = new Print2Print();
            p2p.ShowDialog();
        }
    }
}
