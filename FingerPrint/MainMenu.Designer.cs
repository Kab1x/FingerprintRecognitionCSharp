
namespace FingerPrint
{
    partial class Accueil
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
            this.statusLed = new System.Windows.Forms.Button();
            this.statusLabel = new System.Windows.Forms.Label();
            this.connectToDb = new System.Windows.Forms.Button();
            this.matchingClick = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(171, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Status connexion : ";
            // 
            // statusLed
            // 
            this.statusLed.BackColor = System.Drawing.Color.Red;
            this.statusLed.Location = new System.Drawing.Point(340, 55);
            this.statusLed.Name = "statusLed";
            this.statusLed.Size = new System.Drawing.Size(40, 38);
            this.statusLed.TabIndex = 1;
            this.statusLed.UseVisualStyleBackColor = false;
            // 
            // statusLabel
            // 
            this.statusLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.statusLabel.AutoSize = true;
            this.statusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.statusLabel.Location = new System.Drawing.Point(140, 130);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(256, 20);
            this.statusLabel.TabIndex = 2;
            this.statusLabel.Text = "Non connecté a la base de donnée";
            // 
            // connectToDb
            // 
            this.connectToDb.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.connectToDb.Location = new System.Drawing.Point(31, 246);
            this.connectToDb.Name = "connectToDb";
            this.connectToDb.Size = new System.Drawing.Size(205, 69);
            this.connectToDb.TabIndex = 3;
            this.connectToDb.Text = "Gestion de la base de données";
            this.connectToDb.UseVisualStyleBackColor = true;
            this.connectToDb.Click += new System.EventHandler(this.connectToDb_Click);
            // 
            // matchingClick
            // 
            this.matchingClick.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.matchingClick.Location = new System.Drawing.Point(321, 246);
            this.matchingClick.Name = "matchingClick";
            this.matchingClick.Size = new System.Drawing.Size(204, 69);
            this.matchingClick.TabIndex = 4;
            this.matchingClick.Text = "Correspondance d\'empreintes";
            this.matchingClick.UseVisualStyleBackColor = true;
            this.matchingClick.Click += new System.EventHandler(this.matchingClick_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.button1.Location = new System.Drawing.Point(175, 335);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(204, 55);
            this.button1.TabIndex = 5;
            this.button1.Text = "Comparaison entre 2 Empreintes";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 403);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.matchingClick);
            this.Controls.Add(this.connectToDb);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.statusLed);
            this.Controls.Add(this.label1);
            this.Name = "Accueil";
            this.Text = "Accueil";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button statusLed;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Button connectToDb;
        private System.Windows.Forms.Button matchingClick;
        private System.Windows.Forms.Button button1;
    }
}

