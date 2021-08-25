using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FingerPrint
{
    public partial class FormulairInfoForm : Form
    {
        public static FormulairInfoForm instance;
        public string nomStr;
        public string prenomStr;
        public string dateNaissanceStr;
        public string lieuNaissanceStr;
        public string sexeStr;
        public string adresseStr;

        public FormulairInfoForm()
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

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Choose Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if(opf.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(opf.FileName);
            }
        }


        public int FetchFormData()
        {
            nomStr = nomTextBox.Text;
            prenomStr = prenomTextBox.Text;
            dateNaissanceStr = annee.Text + "-" + mois.Text + "-" + jour.Text;
            lieuNaissanceStr = LieuNaissanceTextBox.Text;
            sexeStr = this.sexeComboBox.Text;
            adresseStr = this.adrTextBox.Text;

            MessageBox.Show(
                nomStr + " " +
                prenomStr + " " +
                dateNaissanceStr + " " +
                lieuNaissanceStr + " " +
                sexeStr + " " +
                adresseStr + " ");

            if (nomStr.Length == 0 ||
                nomStr.Length == 0 ||
                prenomStr.Length == 0 ||
                dateNaissanceStr.Length == 0 ||
                lieuNaissanceStr.Length == 0 ||
                sexeStr.Length == 0 ||
                adresseStr.Length == 0)
            {
                return -1;
                //ERROR IF SOME CHAMPS ARE EMPTY
            }
            else
            {
                return 0;
                //ALL COMPLETE
            }
        }
        public void modifierEmpreintesButton_Click(object sender, EventArgs e)
        {
            if(FetchFormData() == 0)
            {
                Empreintes newForm = new Empreintes();
                newForm.Show();
            }
            else
            {
                MessageBox.Show("Vous avez mal completé le formulair.");
            }
        }
    }
}
