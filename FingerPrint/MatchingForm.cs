using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FingerPrint
{
    public partial class MatchingForm : Form
    {
        public Process defaultImageProc;
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            Application.Exit();
        }

        public MatchingForm()
        {
            InitializeComponent();
        }

        private void fingerprintSearchPictureBox_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Choose Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                fingerprintSearchPictureBox.Image = Image.FromFile(opf.FileName);
            }
        }

        
        private void startSearch_Click(object sender, EventArgs e)
        {
            if(defaultImageProc != null)
            {
                if (defaultImageProc.HasExited == false)
                {
                    defaultImageProc.Kill();
                    MessageBox.Show("Killed process");
                    MessageBox.Show(defaultImageProc.HasExited.ToString());
                }
            }

            resultatPicBox.Image = Properties.Resources.ResultImage;

            Empreintes.CleanDirectories();
            if (!Directory.Exists("InputSamples"))
            {
                Directory.CreateDirectory("InputSamples");
            }
            fingerprintSearchPictureBox.Image.Save(@"InputSamples\0.png");

            if(StartAnalysis() == 0)
            {
                FetchData();
                UpdateUI();
                SearchResults sr = new SearchResults();
                if(sr.InitSearch(endings, bifurcations) != -1)
                {
                    sr.Show();
                }
                else
                {
                    sr.Dispose();
                }

            } else {
                MessageBox.Show("Problem d'analyse de l'empreinte");
            }
        }

        private void UpdateUI()
        {
            UpdatePictureBox();
            resultsLabel.Text = "Resultats de l'analyse: " + endings.ToString() + "  Terminaisons et " +
                bifurcations.ToString() + " Bifurcations";
        }

        public int endings, bifurcations;

        private void FetchData()
        {
            string[] lines = File.ReadAllLines(@"Resultats\0.txt");
            endings = int.Parse(lines[0]);
            bifurcations = int.Parse(lines[1]);
        }

        private void resultatPicBox_Click(object sender, EventArgs e)
        {
            if (File.Exists(@"Resultats\0.png"))
            {
                defaultImageProc = Process.Start(@"Resultats\0.png");
            }
        }
        FileStream rsltImg;
        private void UpdatePictureBox()
        {
            rsltImg = File.OpenRead(@"Resultats\0.png");
            resultatPicBox.Image = Image.FromStream(rsltImg);
            rsltImg.Close();
        }

        private void MatchingForm_Load(object sender, EventArgs e)
        {
            
        }

        public static int StartAnalysis()
        {
            ProcessStartInfo psi = new ProcessStartInfo("cmd");
            psi.Arguments = "/c cd " + Environment.CurrentDirectory + "/Engine&python start.py";
            psi.UseShellExecute = true;
            Process p = Process.Start(psi);
            p.WaitForExit();
            return p.ExitCode;
        }
    }
}
