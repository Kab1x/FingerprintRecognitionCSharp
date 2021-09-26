using FingerPrint.Properties;
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
    
    public partial class Print2Print : Form
    {
        private struct PrintsData
        {
            public float endings;
            public float bifurcations;
            public static bool operator == (PrintsData a, PrintsData b)
            {
                if (a.endings == b.endings && a.bifurcations == b.bifurcations) return true;
                else return false;
            }
            public static bool operator != (PrintsData a, PrintsData b)
            {
                if (a.endings != b.endings || a.bifurcations != b.bifurcations) return true;
                else return false;
            }

            public override bool Equals(object obj)
            {
                return this == (PrintsData)obj;
            }
            public override int GetHashCode()
            {
                return base.GetHashCode();
            }

            
        }

        private bool pic1Loaded = false, pic2Loaded = false;
        public Print2Print()
        {
            InitializeComponent();
        }

        
        private void compareButton_Click(object sender, EventArgs e)
        {
            Empreintes.CleanDirectories();
            if(CheckPicture() == 0)
            {
                StartComparison();
            }
        }

        private int StartComparison(){

            string path = @"InputSamples\";

            pic1.Image.Save(path + "0.png");
            pic2.Image.Save(path + "1.png");

            if (MatchingForm.StartAnalysis() == 0)
            {
                if(FetchData() == 0)
                {
                    DisplayResults();
                }
                else
                {
                    return -2;
                }
            }
            else
            {
                return -1;
            }

            return 0;
        }

        PrintsData p1, p2;

        private float GetSimilarityPercentage(PrintsData a, PrintsData b)
        {
            float endings, bifurcations;

            endings = Math.Abs(a.endings - b.endings);
            bifurcations = Math.Abs(a.bifurcations - b.bifurcations);

            endings = endings / Math.Max(a.endings, b.endings);
            bifurcations = bifurcations / Math.Max(a.bifurcations, b.bifurcations);

            return 100f - ((endings + bifurcations) * 50f);
        }

        private void FillTable()
        {
            this.Height = 567;
            printsDataView.Rows.Add();
            printsDataView.Rows.Add();
            printsDataView.Rows.Add();
            printsDataView.Rows.Add();
            printsDataView.Rows[0].Cells[0].Value = "Terminaisons";
            printsDataView.Rows[0].Cells[1].Value = p1.endings;
            printsDataView.Rows[0].Cells[2].Value = p1.bifurcations;

            printsDataView.Rows[1].Cells[0].Value = "Bifurcations";
            printsDataView.Rows[1].Cells[1].Value = p2.endings;
            printsDataView.Rows[1].Cells[2].Value = p2.bifurcations;


            printsDataView.Rows[2].Cells[0].Value = "Difference";
            printsDataView.Rows[2].Cells[1].Value = "Difference Terminaisons:" + Math.Abs(p2.endings - p1.endings);
            printsDataView.Rows[2].Cells[2].Value = "Difference Bifurcations:" + Math.Abs(p2.bifurcations - p1.bifurcations);

            printsDataView.Rows[3].Cells[0].Value = "Images";
            printsDataView.Rows[3].Cells[1].Value = "Clickez ici pour voir les images analysées de l'empreinte 1";
            printsDataView.Rows[3].Cells[2].Value = "Clickez ici pour voir les images analysées de l'empreinte 2";

        }

        private void DisplayResults()
        {
            tauxSimilarite.Text = GetSimilarityPercentage(p1, p2).ToString("0.00") + "%";
            FillTable();
        }
        
        private int FetchData()
        {
            try
            {
                string[] lines1 = File.ReadAllLines(@"Resultats\0.txt");
                string[] lines2 = File.ReadAllLines(@"Resultats\1.txt");
                p1.endings = float.Parse(lines1[0]);
                p1.bifurcations = float.Parse(lines1[1]);
                p2.endings = float.Parse(lines2[0]);
                p2.bifurcations = float.Parse(lines2[1]);
                return 0;
            }
            catch
            {
                MessageBox.Show("Erreur de lecture des données d'empreintes");
                return -1;
            }
        }
        private int CheckPicture()
        {
            if(pic1Loaded && pic2Loaded)
            {
                return 0;
            }
            else
            {
                MessageBox.Show("Veuillez charger les deux empreintes pour commencer la comparaison");
                return -1;
            }
        }
        private Image GetPicture()
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Choose Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                return Image.FromFile(opf.FileName);
            }
            else
            {
                return null;
            }
        }
        private void Print2Print_Load(object sender, EventArgs e)
        {
            this.Height = 345;
        }

        private void printsDataView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex == 3)
            {
                if(e.ColumnIndex == 1)
                {
                    if (File.Exists(@"Resultats\0.png"))
                    {
                        Process.Start(@"Resultats\0.png");
                    }
                }
                if (e.ColumnIndex == 2)
                {
                    if (File.Exists(@"Resultats\1.png"))
                    {
                        Process.Start(@"Resultats\1.png");
                    }
                }
            }
        }

        private void pic1_Click(object sender, EventArgs e)
        {
            Image buffer = GetPicture();
            if(buffer != null)
            {
                pic1.Image = buffer;
                pic1Loaded = true;
            }
        }
        private void pic2_Click(object sender, EventArgs e)
        {
            Image buffer = GetPicture();
            if (buffer != null)
            {
                pic2.Image = buffer;
                pic2Loaded = true;
            }
        }
    }
}
