using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;

namespace FingerPrint
{
    public partial class Empreintes : Form
    {
        public Empreintes()
        {
            InitializeComponent();
            Directory.CreateDirectory("Data\\Prints");
        }

        private void Empreintes_Load(object sender, EventArgs e)
        {
            personIdLabel.Text = "Nom: " + FormulairInfoForm.instance.nomStr + 
                                " Prenom: " + FormulairInfoForm.instance.prenomStr;
        }
        private Image LoadPicture()
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Choose Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                return Image.FromFile(opf.FileName);
            }
            return null;
        }

        private void left0Image_Click(object sender, EventArgs e)
        {
            left0Image.Image = LoadPicture();
        }
        private void left1Image_Click(object sender, EventArgs e)
        {
            left1Image.Image = LoadPicture();
        }
        private void left2Image_Click(object sender, EventArgs e)
        {
            left2Image.Image = LoadPicture();
        }
        private void left3Image_Click(object sender, EventArgs e)
        {
            left3Image.Image = LoadPicture();
        }
        private void left4Image_Click(object sender, EventArgs e)
        {
            left4Image.Image = LoadPicture();
        }
        private void right0Image_Click(object sender, EventArgs e)
        {
            right0Image.Image = LoadPicture();
        }
        private void right1Image_Click(object sender, EventArgs e)
        {
            right1Image.Image = LoadPicture();
        }
        private void right2Image_Click(object sender, EventArgs e)
        {
            right2Image.Image = LoadPicture();
        }
        private void right3Image_Click(object sender, EventArgs e)
        {
            right3Image.Image = LoadPicture();
        }
        private void right4Image_Click(object sender, EventArgs e)
        {
            right4Image.Image = LoadPicture();
        }

        private void submitFingerPrints_Click(object sender, EventArgs e)
        {
            string nom =  FormulairInfoForm.instance.nomStr;
            string prneom = FormulairInfoForm.instance. prenomStr;
            string dateNaissance = FormulairInfoForm.instance.dateNaissanceStr;
            string lieuNaissance = FormulairInfoForm.instance.lieuNaissanceStr;
            string sexe = FormulairInfoForm.instance.sexeStr;
            string adresse = FormulairInfoForm.instance.adresseStr;


            MySqlConnection mySqlinstance = Accueil.mySqlConInstance;
            try
            {
                new MySqlCommand("INSERT INTO Orders(id, customerId, amount) Values(1001, 23, 30.66)");
            }
            catch (Exception izan)
            {
                MessageBox.Show(izan.ToString());
            }

            //MYSQL STUFF
        }
    }
}
