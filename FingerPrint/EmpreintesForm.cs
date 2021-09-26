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
using System.Drawing.Imaging;
using System.Security.AccessControl;
using System.Diagnostics;

namespace FingerPrint
{
    public partial class Empreintes : Form
    {

        public int personId;


        byte[] gauche0;
        byte[] gauche1;
        byte[] gauche2;
        byte[] gauche3;
        byte[] gauche4;
        byte[] droite4;
        byte[] droite3;
        byte[] droite2;
        byte[] droite1;
        byte[] droite0;

        public Empreintes()
        {
            InitializeComponent();
        }

        private void Empreintes_Load(object sender, EventArgs e)
        {


            personId = GenerateRandomId();
            personIdLabel.Text = "ID: " + personId + 
                                 "\n       Nom: " + FormulairInfoForm.instance.nomStr +
                                 "\n       Prenom: " + FormulairInfoForm.instance.prenomStr;
        }

        

        private Image LoadPicture(out byte[] imageByteArray)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Choose Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                Image OpenedImage = Image.FromFile(opf.FileName);
                MemoryStream mStream = new MemoryStream();
                OpenedImage.Save(mStream, OpenedImage.RawFormat);
                imageByteArray = mStream.ToArray();

                return OpenedImage;
            }
            imageByteArray = null;
            return null;
        }

        private Image buffer;

        bool print0Loaded = false;
        bool print1Loaded = false;
        bool print2Loaded = false;
        bool print3Loaded = false;
        bool print4Loaded = false;
        bool print5Loaded = false;
        bool print6Loaded = false;
        bool print7Loaded = false;
        bool print8Loaded = false;
        bool print9Loaded = false;













        private void left0Image_Click(object sender, EventArgs e)
        {
            buffer = LoadPicture(out gauche0);
            if (buffer != null){
                left0Image.Image = buffer;
                print0Loaded = true;
            }
        }
        private void left1Image_Click(object sender, EventArgs e)
        {
            buffer = LoadPicture(out gauche1);
            if(buffer != null){
                left1Image.Image = buffer;
                print1Loaded = true;
            }
        }
        private void left2Image_Click(object sender, EventArgs e)
        {
            buffer = LoadPicture(out gauche2);
            if(buffer != null){
                left2Image.Image = buffer;
                print2Loaded = true;
            }
        }
        private void left3Image_Click(object sender, EventArgs e)
        {
            buffer = LoadPicture(out gauche3);
            if(buffer != null){
                left3Image.Image = buffer;
                print3Loaded = true;
            }
        }
        private void left4Image_Click(object sender, EventArgs e)
        {
            buffer = LoadPicture(out gauche4);
            if(buffer != null){
                left4Image.Image = buffer;
                print4Loaded = true;
            }
        }
        private void right0Image_Click(object sender, EventArgs e)
        {
            buffer =LoadPicture(out droite0);
            if(buffer != null){
                right0Image.Image = buffer;
                print5Loaded = true;
            }
        }
        private void right1Image_Click(object sender, EventArgs e)
        {
            buffer = LoadPicture(out droite1);
            if(buffer != null){
                right1Image.Image = buffer;
                print6Loaded = true;
            }
        }
        private void right2Image_Click(object sender, EventArgs e)
        {
            buffer = LoadPicture(out droite2);
            if(buffer != null){
                right2Image.Image = buffer;
                print7Loaded = true;
            }
        }
        private void right3Image_Click(object sender, EventArgs e)
        {
            buffer = LoadPicture(out droite3);
            if(buffer != null){
                right3Image.Image = buffer;
                print8Loaded = true;
            }
        }
        private void right4Image_Click(object sender, EventArgs e)
        {
            buffer = LoadPicture(out droite4);
            if(buffer != null){
                right4Image.Image = buffer;
                print9Loaded = true;
            }
        }

        // Instantiate random number generator.  
        private readonly Random _random = new Random();

        // Generates a random number within a range.      
        public int GenerateRandomId()
        {
            return _random.Next(1000, 99999999);
        }



        private MySqlConnection OpenConnectionToDB()
        {
            MySqlConnection con = new MySqlConnection(Accueil.connectionString);
            try
            {
                con.Open();
                return con;
            }
            catch (Exception e)
            {
                MessageBox.Show("ERROR: \nErreur de connexion a la base de donnée " + e.ToString());
                return null;
            }
        }

        public byte[] imageBytesArray;
        
        
        private void ProcessFingerPrints()
        {
            CleanDirectories();
            PreparePrints(); 
            StartAnalysis();
            FetchProcessedData();
        }

        int[,] minutiae = new int[10, 2];
        private string dataString;
        private void FetchProcessedData()
        {
            for(int i = 0; i < 10; i++)
            {
                string[] lines = File.ReadAllLines(@"Resultats\"+i.ToString() + ".txt");

                minutiae[i, 0] = int.Parse(lines[0]);
                minutiae[i, 1] = int.Parse(lines[1]);
            }

            for (int i = 0; i < 10; i++)
            {
                if(i==9)
                {
                    dataString = dataString + minutiae[i, 0].ToString() + "\n";
                    dataString = dataString + minutiae[i, 1].ToString();
                    break;
                }
                dataString = dataString + minutiae[i, 0].ToString() + "\n";
                dataString = dataString + minutiae[i, 1].ToString() + "\n";
            }
        }
        private void StartAnalysis()
        {
            ProcessStartInfo psi = new ProcessStartInfo("cmd");
            psi.Arguments = "/c cd " + Environment.CurrentDirectory + "/Engine&python start.py";
            psi.UseShellExecute = true;
            Process p = Process.Start(psi);
            p.WaitForExit();
        }
        private void PreparePrints()
        {
            if(!Directory.Exists("InputSamples"))
            { 
                Directory.CreateDirectory("InputSamples");
            }
            left0Image.Image.Save(@"InputSamples\0.png");
            left1Image.Image.Save(@"InputSamples\1.png");
            left2Image.Image.Save(@"InputSamples\2.png");
            left3Image.Image.Save(@"InputSamples\3.png");
            left4Image.Image.Save(@"InputSamples\4.png");

            right4Image.Image.Save(@"InputSamples\5.png");
            right3Image.Image.Save(@"InputSamples\6.png");
            right2Image.Image.Save(@"InputSamples\7.png");
            right1Image.Image.Save(@"InputSamples\8.png");
            right0Image.Image.Save(@"InputSamples\9.png");

        }
        public static  void CleanDirectories()
        {
            DirectoryInfo di = new DirectoryInfo("InputSamples");
            foreach (FileInfo file in di.EnumerateFiles())
            {
                file.Delete();
            }
            DirectoryInfo di2 = new DirectoryInfo("Resultats");
            foreach (FileInfo file in di2.EnumerateFiles())
            {
                file.Delete();
            }
        }

        private bool CheckedImages()
        {
            bool AllReady = print0Loaded && print1Loaded && print2Loaded && print3Loaded && print4Loaded && print5Loaded && print6Loaded && print7Loaded && print8Loaded && print9Loaded ;
            if (AllReady)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Veuillez Charger toutes les empreintes avant de commencer l'analyse");
                return false;
            }
        }
        private void submitFingerPrints_Click(object sender, EventArgs e)
        {
            if(CheckedImages() == true)
            {
                ProcessFingerPrints();

                string nom = FormulairInfoForm.instance.nomStr;
                string prenom = FormulairInfoForm.instance.prenomStr;
                string dateNaissance = FormulairInfoForm.instance.dateNaissanceStr;
                string lieuNaissance = FormulairInfoForm.instance.lieuNaissanceStr;
                string sexe = FormulairInfoForm.instance.sexeStr;
                string adresse = FormulairInfoForm.instance.adresseStr;
                Image profilePicture = FormulairInfoForm.instance.ppShared.Image;

                MemoryStream mStream = new MemoryStream();
                profilePicture.Save(mStream, profilePicture.RawFormat);
                imageBytesArray = mStream.ToArray();

                string insertQuery = "INSERT INTO `personne` (ID, `Nom`, `Prenom`, `DateNaissance`, `LieuNaissance`, `Sexe`, `Adresse` , PhotoVisage) VALUES " +
                                                             "(@idPersonne, @nom, @prenom, @dateNaissance, @lieuNaissance, @sexe, @adr, @photoVisage)";

                MySqlConnection connection = OpenConnectionToDB();
                MySqlCommand cmd = new MySqlCommand(insertQuery, connection);

                cmd.Parameters.Add("@idPersonne", MySqlDbType.Int32);
                cmd.Parameters.Add("@nom", MySqlDbType.VarChar);
                cmd.Parameters.Add("@prenom", MySqlDbType.VarChar);
                cmd.Parameters.Add("@dateNaissance", MySqlDbType.VarChar);
                cmd.Parameters.Add("@lieuNaissance", MySqlDbType.VarChar);
                cmd.Parameters.Add("@sexe", MySqlDbType.VarChar);
                cmd.Parameters.Add("@adr", MySqlDbType.VarChar);
                cmd.Parameters.Add("@photoVisage", MySqlDbType.MediumBlob);

                cmd.Parameters["@idPersonne"].Value = personId;
                cmd.Parameters["@nom"].Value = nom;
                cmd.Parameters["@prenom"].Value = prenom;
                cmd.Parameters["@dateNaissance"].Value = dateNaissance;
                cmd.Parameters["@lieuNaissance"].Value = lieuNaissance;
                cmd.Parameters["@sexe"].Value = sexe;
                cmd.Parameters["@adr"].Value = adresse;
                cmd.Parameters["@photoVisage"].Value = imageBytesArray;
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show(nom + " " + prenom + " ajouté avec success");
                }
                catch (Exception exce)
                {
                    MessageBox.Show(exce.ToString());
                }


                string sql = "INSERT INTO `empreintes` (`ID`, userId, Gauche0, Gauche1, Gauche2, Gauche3, Gauche4, Droite4, Droite3, Droite2, Droite1, Droite0, `dataString`) VALUES(NULL, @idPersonne, @gauche0, @gauche1, @gauche2, @gauche3, @gauche4, @droite4, @droite3, @droite2, @droite1, @droite0, @dataString);";
                MySqlCommand printsCmd = new MySqlCommand(sql, connection);

                printsCmd.Parameters.Add("@idPersonne", MySqlDbType.Int32);
                printsCmd.Parameters["@idPersonne"].Value = personId;

                printsCmd.Parameters.Add("@Gauche0", MySqlDbType.MediumBlob);
                printsCmd.Parameters.Add("@Gauche1", MySqlDbType.MediumBlob);
                printsCmd.Parameters.Add("@Gauche2", MySqlDbType.MediumBlob);
                printsCmd.Parameters.Add("@Gauche3", MySqlDbType.MediumBlob);
                printsCmd.Parameters.Add("@Gauche4", MySqlDbType.MediumBlob);
                printsCmd.Parameters.Add("@Droite4", MySqlDbType.MediumBlob);
                printsCmd.Parameters.Add("@Droite3", MySqlDbType.MediumBlob);
                printsCmd.Parameters.Add("@Droite2", MySqlDbType.MediumBlob);
                printsCmd.Parameters.Add("@Droite1", MySqlDbType.MediumBlob);
                printsCmd.Parameters.Add("@Droite0", MySqlDbType.MediumBlob);
                printsCmd.Parameters.Add("@dataString", MySqlDbType.VarChar);


                printsCmd.Parameters["@Gauche0"].Value = gauche0;
                printsCmd.Parameters["@Gauche1"].Value = gauche1;
                printsCmd.Parameters["@Gauche2"].Value = gauche2;
                printsCmd.Parameters["@Gauche3"].Value = gauche3;
                printsCmd.Parameters["@Gauche4"].Value = gauche4;
                printsCmd.Parameters["@Droite4"].Value = droite4;
                printsCmd.Parameters["@Droite3"].Value = droite3;
                printsCmd.Parameters["@Droite2"].Value = droite2;
                printsCmd.Parameters["@Droite1"].Value = droite1;
                printsCmd.Parameters["@Droite0"].Value = droite0;
                printsCmd.Parameters["@dataString"].Value = dataString;

                try
                {
                    printsCmd.ExecuteNonQuery();
                }
                catch (Exception exce)
                {
                    MessageBox.Show(exce.ToString());
                }
                CleanDirectories();

                this.Close();
            }
        }
    }
}
