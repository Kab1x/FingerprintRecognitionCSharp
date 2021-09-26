
namespace FingerPrint
{
    partial class Print2Print
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Print2Print));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pic1 = new System.Windows.Forms.PictureBox();
            this.pic2 = new System.Windows.Forms.PictureBox();
            this.compareButton = new System.Windows.Forms.Button();
            this.tauxSimilarite = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.printsDataView = new System.Windows.Forms.DataGridView();
            this.Info = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.printsDataView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label1.Location = new System.Drawing.Point(76, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Empreinte 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label2.Location = new System.Drawing.Point(616, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Empreinte 2";
            // 
            // pic1
            // 
            this.pic1.Image = global::FingerPrint.Properties.Resources.LargeFingerprintICON;
            this.pic1.Location = new System.Drawing.Point(12, 44);
            this.pic1.Name = "pic1";
            this.pic1.Size = new System.Drawing.Size(241, 250);
            this.pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic1.TabIndex = 2;
            this.pic1.TabStop = false;
            this.pic1.Click += new System.EventHandler(this.pic1_Click);
            // 
            // pic2
            // 
            this.pic2.Image = ((System.Drawing.Image)(resources.GetObject("pic2.Image")));
            this.pic2.Location = new System.Drawing.Point(547, 44);
            this.pic2.Name = "pic2";
            this.pic2.Size = new System.Drawing.Size(241, 250);
            this.pic2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic2.TabIndex = 3;
            this.pic2.TabStop = false;
            this.pic2.Click += new System.EventHandler(this.pic2_Click);
            // 
            // compareButton
            // 
            this.compareButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.compareButton.Location = new System.Drawing.Point(294, 137);
            this.compareButton.Name = "compareButton";
            this.compareButton.Size = new System.Drawing.Size(228, 39);
            this.compareButton.TabIndex = 4;
            this.compareButton.Text = "Comparer";
            this.compareButton.UseVisualStyleBackColor = true;
            this.compareButton.Click += new System.EventHandler(this.compareButton_Click);
            // 
            // tauxSimilarite
            // 
            this.tauxSimilarite.AutoSize = true;
            this.tauxSimilarite.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.tauxSimilarite.Location = new System.Drawing.Point(368, 224);
            this.tauxSimilarite.Name = "tauxSimilarite";
            this.tauxSimilarite.Size = new System.Drawing.Size(71, 22);
            this.tauxSimilarite.TabIndex = 7;
            this.tauxSimilarite.Text = "00.00%";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label3.Location = new System.Drawing.Point(321, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 22);
            this.label3.TabIndex = 8;
            this.label3.Text = "Taux de similarité:";
            // 
            // printsDataView
            // 
            this.printsDataView.AllowUserToAddRows = false;
            this.printsDataView.AllowUserToDeleteRows = false;
            this.printsDataView.AllowUserToResizeColumns = false;
            this.printsDataView.AllowUserToResizeRows = false;
            this.printsDataView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.printsDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.printsDataView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Info,
            this.Column1,
            this.Column2});
            this.printsDataView.Location = new System.Drawing.Point(12, 324);
            this.printsDataView.Name = "printsDataView";
            this.printsDataView.RowTemplate.Height = 40;
            this.printsDataView.Size = new System.Drawing.Size(776, 194);
            this.printsDataView.TabIndex = 9;
            this.printsDataView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.printsDataView_CellContentClick);
            // 
            // Info
            // 
            this.Info.FillWeight = 50F;
            this.Info.HeaderText = "Informations";
            this.Info.Name = "Info";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Empreinte 1";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Empreinte 2";
            this.Column2.Name = "Column2";
            // 
            // Print2Print
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 528);
            this.Controls.Add(this.printsDataView);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tauxSimilarite);
            this.Controls.Add(this.compareButton);
            this.Controls.Add(this.pic2);
            this.Controls.Add(this.pic1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Print2Print";
            this.Text = "Print2Print";
            this.Load += new System.EventHandler(this.Print2Print_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.printsDataView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pic1;
        private System.Windows.Forms.PictureBox pic2;
        private System.Windows.Forms.Button compareButton;
        private System.Windows.Forms.Label tauxSimilarite;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView printsDataView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Info;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}