
namespace FingerPrint
{
    partial class SearchResults
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
            this.label1 = new System.Windows.Forms.Label();
            this.mainTextLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nomLabel = new System.Windows.Forms.Label();
            this.prenomLabel = new System.Windows.Forms.Label();
            this.dateNaissanceLabel = new System.Windows.Forms.Label();
            this.sexeLabel = new System.Windows.Forms.Label();
            this.lieuNaissanceLabel = new System.Windows.Forms.Label();
            this.adresseLabel = new System.Windows.Forms.Label();
            this.photoProfile = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.photoProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label1.Location = new System.Drawing.Point(281, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Résultats de la recherche:";
            // 
            // mainTextLabel
            // 
            this.mainTextLabel.AutoSize = true;
            this.mainTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.mainTextLabel.Location = new System.Drawing.Point(12, 58);
            this.mainTextLabel.Name = "mainTextLabel";
            this.mainTextLabel.Size = new System.Drawing.Size(291, 18);
            this.mainTextLabel.TabIndex = 1;
            this.mainTextLabel.Text = "Correspondance d\'empreinte trouvé avec:  ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label2.Location = new System.Drawing.Point(260, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(240, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Plus d\'informations sur la peronne: ";
            // 
            // nomLabel
            // 
            this.nomLabel.AutoSize = true;
            this.nomLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.nomLabel.Location = new System.Drawing.Point(12, 172);
            this.nomLabel.Name = "nomLabel";
            this.nomLabel.Size = new System.Drawing.Size(41, 18);
            this.nomLabel.TabIndex = 3;
            this.nomLabel.Text = "Nom";
            // 
            // prenomLabel
            // 
            this.prenomLabel.AutoSize = true;
            this.prenomLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.prenomLabel.Location = new System.Drawing.Point(12, 202);
            this.prenomLabel.Name = "prenomLabel";
            this.prenomLabel.Size = new System.Drawing.Size(61, 18);
            this.prenomLabel.TabIndex = 4;
            this.prenomLabel.Text = "Prenom";
            // 
            // dateNaissanceLabel
            // 
            this.dateNaissanceLabel.AutoSize = true;
            this.dateNaissanceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.dateNaissanceLabel.Location = new System.Drawing.Point(12, 235);
            this.dateNaissanceLabel.Name = "dateNaissanceLabel";
            this.dateNaissanceLabel.Size = new System.Drawing.Size(164, 18);
            this.dateNaissanceLabel.TabIndex = 5;
            this.dateNaissanceLabel.Text = "Date De Naissance: Le ";
            // 
            // sexeLabel
            // 
            this.sexeLabel.AutoSize = true;
            this.sexeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.sexeLabel.Location = new System.Drawing.Point(12, 305);
            this.sexeLabel.Name = "sexeLabel";
            this.sexeLabel.Size = new System.Drawing.Size(41, 18);
            this.sexeLabel.TabIndex = 6;
            this.sexeLabel.Text = "Sexe";
            // 
            // lieuNaissanceLabel
            // 
            this.lieuNaissanceLabel.AutoSize = true;
            this.lieuNaissanceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lieuNaissanceLabel.Location = new System.Drawing.Point(12, 270);
            this.lieuNaissanceLabel.Name = "lieuNaissanceLabel";
            this.lieuNaissanceLabel.Size = new System.Drawing.Size(156, 18);
            this.lieuNaissanceLabel.TabIndex = 7;
            this.lieuNaissanceLabel.Text = "Lieu  De Naissance: à ";
            // 
            // adresseLabel
            // 
            this.adresseLabel.AutoSize = true;
            this.adresseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.adresseLabel.Location = new System.Drawing.Point(12, 336);
            this.adresseLabel.Name = "adresseLabel";
            this.adresseLabel.Size = new System.Drawing.Size(70, 18);
            this.adresseLabel.TabIndex = 8;
            this.adresseLabel.Text = "Adresse: ";
            // 
            // photoProfile
            // 
            this.photoProfile.Location = new System.Drawing.Point(592, 172);
            this.photoProfile.Name = "photoProfile";
            this.photoProfile.Size = new System.Drawing.Size(182, 182);
            this.photoProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.photoProfile.TabIndex = 9;
            this.photoProfile.TabStop = false;
            // 
            // SearchResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 387);
            this.Controls.Add(this.photoProfile);
            this.Controls.Add(this.adresseLabel);
            this.Controls.Add(this.lieuNaissanceLabel);
            this.Controls.Add(this.sexeLabel);
            this.Controls.Add(this.dateNaissanceLabel);
            this.Controls.Add(this.prenomLabel);
            this.Controls.Add(this.nomLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mainTextLabel);
            this.Controls.Add(this.label1);
            this.Name = "SearchResults";
            this.Text = "SearchResults";
            this.Load += new System.EventHandler(this.SearchResults_Load);
            ((System.ComponentModel.ISupportInitialize)(this.photoProfile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label mainTextLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label nomLabel;
        private System.Windows.Forms.Label prenomLabel;
        private System.Windows.Forms.Label dateNaissanceLabel;
        private System.Windows.Forms.Label sexeLabel;
        private System.Windows.Forms.Label lieuNaissanceLabel;
        private System.Windows.Forms.Label adresseLabel;
        private System.Windows.Forms.PictureBox photoProfile;
    }
}