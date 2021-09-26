
namespace FingerPrint
{
    partial class MatchingForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MatchingForm));
            this.fingerprintSearchPictureBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.startSearch = new System.Windows.Forms.Button();
            this.resultatPicBox = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.resultsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fingerprintSearchPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultatPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // fingerprintSearchPictureBox
            // 
            this.fingerprintSearchPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("fingerprintSearchPictureBox.Image")));
            this.fingerprintSearchPictureBox.Location = new System.Drawing.Point(12, 91);
            this.fingerprintSearchPictureBox.Name = "fingerprintSearchPictureBox";
            this.fingerprintSearchPictureBox.Size = new System.Drawing.Size(241, 250);
            this.fingerprintSearchPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fingerprintSearchPictureBox.TabIndex = 0;
            this.fingerprintSearchPictureBox.TabStop = false;
            this.fingerprintSearchPictureBox.Click += new System.EventHandler(this.fingerprintSearchPictureBox_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label1.Location = new System.Drawing.Point(315, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Recherche de personne par empreinte";
            // 
            // startSearch
            // 
            this.startSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.startSearch.Location = new System.Drawing.Point(259, 202);
            this.startSearch.Name = "startSearch";
            this.startSearch.Size = new System.Drawing.Size(136, 43);
            this.startSearch.TabIndex = 2;
            this.startSearch.Text = "Rechercher =>";
            this.startSearch.UseVisualStyleBackColor = true;
            this.startSearch.Click += new System.EventHandler(this.startSearch_Click);
            // 
            // resultatPicBox
            // 
            this.resultatPicBox.Image = ((System.Drawing.Image)(resources.GetObject("resultatPicBox.Image")));
            this.resultatPicBox.Location = new System.Drawing.Point(401, 91);
            this.resultatPicBox.Name = "resultatPicBox";
            this.resultatPicBox.Size = new System.Drawing.Size(519, 250);
            this.resultatPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.resultatPicBox.TabIndex = 3;
            this.resultatPicBox.TabStop = false;
            this.resultatPicBox.Click += new System.EventHandler(this.resultatPicBox_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(33, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Etape 1: Charger l\'empreinte";
            // 
            // resultsLabel
            // 
            this.resultsLabel.AutoSize = true;
            this.resultsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.resultsLabel.Location = new System.Drawing.Point(397, 367);
            this.resultsLabel.Name = "resultsLabel";
            this.resultsLabel.Size = new System.Drawing.Size(195, 22);
            this.resultsLabel.TabIndex = 5;
            this.resultsLabel.Text = "Resultats de l\'analyse: ";
            // 
            // MatchingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(932, 480);
            this.Controls.Add(this.resultsLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.resultatPicBox);
            this.Controls.Add(this.startSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fingerprintSearchPictureBox);
            this.Name = "MatchingForm";
            this.Text = "MatchingForm";
            this.Load += new System.EventHandler(this.MatchingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fingerprintSearchPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultatPicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox fingerprintSearchPictureBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button startSearch;
        private System.Windows.Forms.PictureBox resultatPicBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label resultsLabel;
    }
}