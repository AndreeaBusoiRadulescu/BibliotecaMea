namespace BibliotecaMea
{
    partial class Editare
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
            this.gbDetalii = new System.Windows.Forms.GroupBox();
            this.btnAnulare = new System.Windows.Forms.Button();
            this.cbStare = new System.Windows.Forms.ComboBox();
            this.btnModifica = new System.Windows.Forms.Button();
            this.tbDenumire = new System.Windows.Forms.TextBox();
            this.tbScriitor = new System.Windows.Forms.TextBox();
            this.dtpPublicatie = new System.Windows.Forms.DateTimePicker();
            this.lblDenumire = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.lblScriitor = new System.Windows.Forms.Label();
            this.lblStare = new System.Windows.Forms.Label();
            this.gbDetalii.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDetalii
            // 
            this.gbDetalii.Controls.Add(this.btnAnulare);
            this.gbDetalii.Controls.Add(this.cbStare);
            this.gbDetalii.Controls.Add(this.btnModifica);
            this.gbDetalii.Controls.Add(this.tbDenumire);
            this.gbDetalii.Controls.Add(this.tbScriitor);
            this.gbDetalii.Controls.Add(this.dtpPublicatie);
            this.gbDetalii.Controls.Add(this.lblDenumire);
            this.gbDetalii.Controls.Add(this.lblData);
            this.gbDetalii.Controls.Add(this.lblScriitor);
            this.gbDetalii.Controls.Add(this.lblStare);
            this.gbDetalii.Location = new System.Drawing.Point(12, 12);
            this.gbDetalii.Name = "gbDetalii";
            this.gbDetalii.Size = new System.Drawing.Size(293, 372);
            this.gbDetalii.TabIndex = 11;
            this.gbDetalii.TabStop = false;
            this.gbDetalii.Text = "Detalii carte";
            // 
            // btnAnulare
            // 
            this.btnAnulare.Location = new System.Drawing.Point(79, 298);
            this.btnAnulare.Name = "btnAnulare";
            this.btnAnulare.Size = new System.Drawing.Size(117, 44);
            this.btnAnulare.TabIndex = 15;
            this.btnAnulare.Text = "Anulare";
            this.btnAnulare.UseVisualStyleBackColor = true;
            this.btnAnulare.Click += new System.EventHandler(this.btnAnulare_Click);
            // 
            // cbStare
            // 
            this.cbStare.FormattingEnabled = true;
            this.cbStare.Items.AddRange(new object[] {
            "citita",
            "necitita"});
            this.cbStare.Location = new System.Drawing.Point(17, 191);
            this.cbStare.Name = "cbStare";
            this.cbStare.Size = new System.Drawing.Size(248, 24);
            this.cbStare.TabIndex = 8;
            // 
            // btnModifica
            // 
            this.btnModifica.Location = new System.Drawing.Point(79, 238);
            this.btnModifica.Name = "btnModifica";
            this.btnModifica.Size = new System.Drawing.Size(117, 44);
            this.btnModifica.TabIndex = 9;
            this.btnModifica.Text = "Modifica";
            this.btnModifica.UseVisualStyleBackColor = true;
            this.btnModifica.Click += new System.EventHandler(this.btnModifica_Click);
            // 
            // tbDenumire
            // 
            this.tbDenumire.Location = new System.Drawing.Point(17, 55);
            this.tbDenumire.Name = "tbDenumire";
            this.tbDenumire.Size = new System.Drawing.Size(248, 22);
            this.tbDenumire.TabIndex = 0;
            // 
            // tbScriitor
            // 
            this.tbScriitor.Location = new System.Drawing.Point(17, 100);
            this.tbScriitor.Name = "tbScriitor";
            this.tbScriitor.Size = new System.Drawing.Size(248, 22);
            this.tbScriitor.TabIndex = 1;
            // 
            // dtpPublicatie
            // 
            this.dtpPublicatie.Location = new System.Drawing.Point(17, 145);
            this.dtpPublicatie.Name = "dtpPublicatie";
            this.dtpPublicatie.Size = new System.Drawing.Size(248, 22);
            this.dtpPublicatie.TabIndex = 7;
            // 
            // lblDenumire
            // 
            this.lblDenumire.AutoSize = true;
            this.lblDenumire.Location = new System.Drawing.Point(14, 31);
            this.lblDenumire.Name = "lblDenumire";
            this.lblDenumire.Size = new System.Drawing.Size(105, 17);
            this.lblDenumire.TabIndex = 3;
            this.lblDenumire.Text = "Denumire carte";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(14, 125);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(105, 17);
            this.lblData.TabIndex = 6;
            this.lblData.Text = "Data publicatiei";
            // 
            // lblScriitor
            // 
            this.lblScriitor.AutoSize = true;
            this.lblScriitor.Location = new System.Drawing.Point(14, 80);
            this.lblScriitor.Name = "lblScriitor";
            this.lblScriitor.Size = new System.Drawing.Size(91, 17);
            this.lblScriitor.TabIndex = 4;
            this.lblScriitor.Text = "Nume scriitor";
            // 
            // lblStare
            // 
            this.lblStare.AutoSize = true;
            this.lblStare.Location = new System.Drawing.Point(14, 170);
            this.lblStare.Name = "lblStare";
            this.lblStare.Size = new System.Drawing.Size(42, 17);
            this.lblStare.TabIndex = 5;
            this.lblStare.Text = "Stare";
            // 
            // Editare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 397);
            this.Controls.Add(this.gbDetalii);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Editare";
            this.Text = "Editare";
            this.Load += new System.EventHandler(this.Editare_Load);
            this.gbDetalii.ResumeLayout(false);
            this.gbDetalii.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDetalii;
        private System.Windows.Forms.Button btnAnulare;
        private System.Windows.Forms.ComboBox cbStare;
        private System.Windows.Forms.Button btnModifica;
        private System.Windows.Forms.TextBox tbDenumire;
        private System.Windows.Forms.TextBox tbScriitor;
        private System.Windows.Forms.DateTimePicker dtpPublicatie;
        private System.Windows.Forms.Label lblDenumire;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblScriitor;
        private System.Windows.Forms.Label lblStare;
    }
}