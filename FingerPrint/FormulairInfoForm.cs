using MySql.Data.MySqlClient;
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

namespace FingerPrint
{
    public partial class FormulairInfoForm : Form
    {
        public PictureBox ppShared;
        public static FormulairInfoForm instance;
        public string nomStr;
        public string prenomStr;
        public string dateNaissanceStr;
        public string lieuNaissanceStr;
        public string sexeStr;
        public string adresseStr;

        private string action;
        private Personne modifyingPerson;

        public FormulairInfoForm(Personne p)
        {
            modifyingPerson = p;
            InitForm();
            string[] subs = p.dateNaissance.Split('/');
            nomTextBox.Text = p.nom;
            prenomTextBox.Text = p.prenom;
            jour.SelectedIndex = int.Parse(subs[0]) -1;
            mois.SelectedIndex = int.Parse(subs[1]) -1;
            annee.Text = subs[2];
            LieuNaissanceTextBox.Text = p.lieuNaissance;
            sexeComboBox.Text = p.sexe;
            adrTextBox.Text = p.adresse;
            MemoryStream ms = new MemoryStream(p.profilePicture);
            profilePicture.Image = Image.FromStream(ms);
            ms.Close();
            action = "modifier";
        }
        public FormulairInfoForm()
        {
            InitForm();
            action = "ajouter";
        }


        public void InitForm()
        {
            InitializeComponent();
            instance = this;

            this.sexeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            this.mois.DropDownStyle = ComboBoxStyle.DropDownList;
            this.jour.DropDownStyle = ComboBoxStyle.DropDownList;
            this.annee.MaxLength = 4;

            this.mois.Items.AddRange(new object[]
            {
                01,
                02,
                03,
                04,
                05,
                06,
                07,
                08,
                09,
                10,
                11,
                12
            });
            this.jour.Items.AddRange(new object[]
            {
                01,
                02,
                03,
                04,
                05,
                06,
                07,
                08,
                09,
                10,
                11,
                12,
                13,
                14,
                15,
                16,
                17,
                18,
                19,
                20,
                21,
                22,
                23,
                24,
                25,
                26,
                27,
                28,
                29,
                30,
                31
            });
            this.sexeComboBox.Items.AddRange(new object[]
            {
                "Homme",
                "Femme"
            });
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Choose Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if(opf.ShowDialog() == DialogResult.OK)
            {
                profilePicture.Image = Image.FromFile(opf.FileName);
            }
        }


        public int FetchFormData()
        {
            nomStr = nomTextBox.Text;
            prenomStr = prenomTextBox.Text;
            dateNaissanceStr = annee.Text + "-" + mois.Text + "-" + jour.Text;
            lieuNaissanceStr = LieuNaissanceTextBox.Text;
            sexeStr = sexeComboBox.Text;
            adresseStr = adrTextBox.Text;
            ppShared = profilePicture;

            if (
                    nomStr.Length == 0 ||
                    prenomStr.Length == 0 ||
                    dateNaissanceStr.Length == 0 ||
                    lieuNaissanceStr.Length == 0 ||
                    sexeStr.Length == 0 ||
                    adresseStr.Length == 0
                )
            {
                return -1;
                //ERROR IF SOME FIELDS ARE EMPTY
            }
            else
            {
                return 0;
                //ALL COMPLETE
            }
        }
        public void modifierEmpreintesButton_Click(object sender, EventArgs e)
        {
           
            if(FetchFormData() == 0) //Formulair complet.
            {
                if (int.TryParse(annee.Text, out _) == false)
                {
                    MessageBox.Show("Année de naissance éronée");
                    return;
                }
                if(action == "ajouter")
                {
                    Empreintes newForm = new Empreintes();
                    newForm.Show();
                }else if(action == "modifier")
                {
                    DialogResult dialogResult = MessageBox.Show("Êtes-vous sûr de vouloir enregistrer les nouvelles modifications", "Attention!", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        UpdateDatabaseInfo();
                    }
                }
            }
            else //ERROR IF SOME FIELDS ARE EMPTY
            {
                MessageBox.Show("Vous avez mal completé le formulair.");
            }
        }

        void UpdateDatabaseInfo()
        {
            MySqlConnection con = new MySqlConnection(Accueil.connectionString);
            con.Open();
            
            string sql = "UPDATE personne SET `Nom` = @nom, `Prenom` = @prenom, `DateNaissance`= @dateNaissance, `LieuNaissance`= @lieuNaissance, `Sexe` = @sexe, `Adresse` = @adr , PhotoVisage = @photoVisage WHERE id="+modifyingPerson.id+";";

            MySqlCommand cmd = new MySqlCommand(sql, con);

            cmd.Parameters.Add("@nom", MySqlDbType.VarChar);
            cmd.Parameters.Add("@prenom", MySqlDbType.VarChar);
            cmd.Parameters.Add("@dateNaissance", MySqlDbType.VarChar);
            cmd.Parameters.Add("@lieuNaissance", MySqlDbType.VarChar);
            cmd.Parameters.Add("@sexe", MySqlDbType.VarChar);
            cmd.Parameters.Add("@adr", MySqlDbType.VarChar);
            cmd.Parameters.Add("@photoVisage", MySqlDbType.MediumBlob);

            cmd.Parameters["@nom"].Value = nomTextBox.Text;
            cmd.Parameters["@prenom"].Value = prenomTextBox.Text;
            cmd.Parameters["@dateNaissance"].Value = annee.Text + "-" + mois.Text + "-" + jour.Text;
            cmd.Parameters["@lieuNaissance"].Value = LieuNaissanceTextBox.Text;
            cmd.Parameters["@sexe"].Value = sexeComboBox.Text;
            cmd.Parameters["@adr"].Value = adrTextBox.Text;

            MemoryStream mStream = new MemoryStream();
            profilePicture.Image.Save(mStream, profilePicture.Image.RawFormat);
            byte[] imageBytesArray = mStream.ToArray();

            cmd.Parameters["@photoVisage"].Value = imageBytesArray;
            cmd.ExecuteNonQuery();
            MessageBox.Show("Changements efféctués avec succès");

            this.Close();
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
        }
    }
}
