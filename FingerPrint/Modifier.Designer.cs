
namespace FingerPrint
{
    partial class Modifier
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataTable = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datenaissance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lieunaissance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.visage = new System.Windows.Forms.DataGridViewImageColumn();
            this.deleteButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.modifierButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable)).BeginInit();
            this.SuspendLayout();
            // 
            // dataTable
            // 
            this.dataTable.AllowUserToAddRows = false;
            this.dataTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataTable.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nom,
            this.prenom,
            this.datenaissance,
            this.lieunaissance,
            this.sexe,
            this.adr,
            this.visage,
            this.deleteButton,
            this.modifierButton});
            this.dataTable.Location = new System.Drawing.Point(12, 12);
            this.dataTable.Name = "dataTable";
            this.dataTable.ReadOnly = true;
            this.dataTable.RowTemplate.Height = 100;
            this.dataTable.Size = new System.Drawing.Size(1007, 530);
            this.dataTable.TabIndex = 0;
            this.dataTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataTable_CellClick);
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // nom
            // 
            this.nom.HeaderText = "Nom";
            this.nom.Name = "nom";
            this.nom.ReadOnly = true;
            // 
            // prenom
            // 
            this.prenom.HeaderText = "Prenom";
            this.prenom.Name = "prenom";
            this.prenom.ReadOnly = true;
            // 
            // datenaissance
            // 
            this.datenaissance.FillWeight = 75F;
            this.datenaissance.HeaderText = "Date.N";
            this.datenaissance.Name = "datenaissance";
            this.datenaissance.ReadOnly = true;
            // 
            // lieunaissance
            // 
            this.lieunaissance.FillWeight = 125F;
            this.lieunaissance.HeaderText = "Lieu.N";
            this.lieunaissance.Name = "lieunaissance";
            this.lieunaissance.ReadOnly = true;
            // 
            // sexe
            // 
            this.sexe.FillWeight = 50F;
            this.sexe.HeaderText = "Sexe";
            this.sexe.Name = "sexe";
            this.sexe.ReadOnly = true;
            // 
            // adr
            // 
            this.adr.FillWeight = 200F;
            this.adr.HeaderText = "Adresse";
            this.adr.Name = "adr";
            this.adr.ReadOnly = true;
            // 
            // visage
            // 
            this.visage.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.visage.HeaderText = "Photo Visage";
            this.visage.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.visage.Name = "visage";
            this.visage.ReadOnly = true;
            this.visage.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // deleteButton
            // 
            this.deleteButton.HeaderText = "Supprimer";
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.ReadOnly = true;
            this.deleteButton.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // modifierButton
            // 
            this.modifierButton.HeaderText = "Modifier";
            this.modifierButton.Name = "modifierButton";
            this.modifierButton.ReadOnly = true;
            this.modifierButton.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.modifierButton.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.button1.Location = new System.Drawing.Point(380, 548);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(285, 53);
            this.button1.TabIndex = 1;
            this.button1.Text = "Ajouter une personne";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Modifier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 613);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataTable);
            this.Name = "Modifier";
            this.Text = "Modifier";
            this.Load += new System.EventHandler(this.Modifier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataTable;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn datenaissance;
        private System.Windows.Forms.DataGridViewTextBoxColumn lieunaissance;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexe;
        private System.Windows.Forms.DataGridViewTextBoxColumn adr;
        private System.Windows.Forms.DataGridViewImageColumn visage;
        private System.Windows.Forms.DataGridViewButtonColumn deleteButton;
        private System.Windows.Forms.DataGridViewButtonColumn modifierButton;
    }
}