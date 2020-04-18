namespace BibliotecaMea
{
    partial class FormularCarte
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
            this.components = new System.ComponentModel.Container();
            this.tbDenumire = new System.Windows.Forms.TextBox();
            this.tbScriitor = new System.Windows.Forms.TextBox();
            this.lblDenumire = new System.Windows.Forms.Label();
            this.lblScriitor = new System.Windows.Forms.Label();
            this.lblStare = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.dtpPublicatie = new System.Windows.Forms.DateTimePicker();
            this.cbStare = new System.Windows.Forms.ComboBox();
            this.btnAdauga = new System.Windows.Forms.Button();
            this.gbDetalii = new System.Windows.Forms.GroupBox();
            this.btnElibereazaCampuri = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.epDenumire = new System.Windows.Forms.ErrorProvider(this.components);
            this.epPublicatie = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnEditare = new System.Windows.Forms.Button();
            this.btnSterge = new System.Windows.Forms.Button();
            this.lvCarte = new System.Windows.Forms.ListView();
            this.columnHeaderDenumire = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderScriitor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderStare = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.epStare = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbDetalii.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epDenumire)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epPublicatie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epStare)).BeginInit();
            this.SuspendLayout();
            // 
            // tbDenumire
            // 
            this.tbDenumire.Location = new System.Drawing.Point(125, 31);
            this.tbDenumire.Name = "tbDenumire";
            this.tbDenumire.Size = new System.Drawing.Size(248, 22);
            this.tbDenumire.TabIndex = 0;
            this.tbDenumire.Validating += new System.ComponentModel.CancelEventHandler(this.tbDenumire_Validating_1);
            this.tbDenumire.Validated += new System.EventHandler(this.tbDenumire_Validated_1);
            // 
            // tbScriitor
            // 
            this.tbScriitor.Location = new System.Drawing.Point(125, 59);
            this.tbScriitor.Name = "tbScriitor";
            this.tbScriitor.Size = new System.Drawing.Size(248, 22);
            this.tbScriitor.TabIndex = 1;
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
            // lblScriitor
            // 
            this.lblScriitor.AutoSize = true;
            this.lblScriitor.Location = new System.Drawing.Point(14, 64);
            this.lblScriitor.Name = "lblScriitor";
            this.lblScriitor.Size = new System.Drawing.Size(91, 17);
            this.lblScriitor.TabIndex = 4;
            this.lblScriitor.Text = "Nume scriitor";
            // 
            // lblStare
            // 
            this.lblStare.AutoSize = true;
            this.lblStare.Location = new System.Drawing.Point(14, 121);
            this.lblStare.Name = "lblStare";
            this.lblStare.Size = new System.Drawing.Size(96, 34);
            this.lblStare.TabIndex = 5;
            this.lblStare.Text = "Stare\r\n(citita/necitita)";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(14, 92);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(105, 17);
            this.lblData.TabIndex = 6;
            this.lblData.Text = "Data publicatiei";
            // 
            // dtpPublicatie
            // 
            this.dtpPublicatie.Location = new System.Drawing.Point(125, 87);
            this.dtpPublicatie.Name = "dtpPublicatie";
            this.dtpPublicatie.Size = new System.Drawing.Size(248, 22);
            this.dtpPublicatie.TabIndex = 7;
            this.dtpPublicatie.Validating += new System.ComponentModel.CancelEventHandler(this.dtpPublicatie_Validating);
            this.dtpPublicatie.Validated += new System.EventHandler(this.dtpPublicatie_Validated);
            // 
            // cbStare
            // 
            this.cbStare.FormattingEnabled = true;
            this.cbStare.Items.AddRange(new object[] {
            "citita",
            "necitita"});
            this.cbStare.Location = new System.Drawing.Point(125, 115);
            this.cbStare.Name = "cbStare";
            this.cbStare.Size = new System.Drawing.Size(248, 24);
            this.cbStare.TabIndex = 8;
            this.cbStare.Validating += new System.ComponentModel.CancelEventHandler(this.cbStare_Validating);
            this.cbStare.Validated += new System.EventHandler(this.cbStare_Validated);
            // 
            // btnAdauga
            // 
            this.btnAdauga.Location = new System.Drawing.Point(482, 31);
            this.btnAdauga.Name = "btnAdauga";
            this.btnAdauga.Size = new System.Drawing.Size(117, 44);
            this.btnAdauga.TabIndex = 9;
            this.btnAdauga.Text = "Adauga carte";
            this.btnAdauga.UseVisualStyleBackColor = true;
            this.btnAdauga.Click += new System.EventHandler(this.btnAdauga_Click);
            // 
            // gbDetalii
            // 
            this.gbDetalii.Controls.Add(this.btnElibereazaCampuri);
            this.gbDetalii.Controls.Add(this.cbStare);
            this.gbDetalii.Controls.Add(this.btnAdauga);
            this.gbDetalii.Controls.Add(this.tbDenumire);
            this.gbDetalii.Controls.Add(this.tbScriitor);
            this.gbDetalii.Controls.Add(this.dtpPublicatie);
            this.gbDetalii.Controls.Add(this.lblDenumire);
            this.gbDetalii.Controls.Add(this.lblData);
            this.gbDetalii.Controls.Add(this.lblScriitor);
            this.gbDetalii.Controls.Add(this.lblStare);
            this.gbDetalii.Location = new System.Drawing.Point(12, 31);
            this.gbDetalii.Name = "gbDetalii";
            this.gbDetalii.Size = new System.Drawing.Size(662, 166);
            this.gbDetalii.TabIndex = 10;
            this.gbDetalii.TabStop = false;
            this.gbDetalii.Text = "Detalii carte";
            // 
            // btnElibereazaCampuri
            // 
            this.btnElibereazaCampuri.Location = new System.Drawing.Point(482, 95);
            this.btnElibereazaCampuri.Name = "btnElibereazaCampuri";
            this.btnElibereazaCampuri.Size = new System.Drawing.Size(117, 44);
            this.btnElibereazaCampuri.TabIndex = 10;
            this.btnElibereazaCampuri.Text = "Elibereaza\r\ncampuri";
            this.btnElibereazaCampuri.UseVisualStyleBackColor = true;
            this.btnElibereazaCampuri.Click += new System.EventHandler(this.btnElibereazaCampuri_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(686, 28);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Menu
            // 
            this.Menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(62, 24);
            this.Menu.Text = "Meniu";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(131, 26);
            this.toolStripMenuItem1.Text = "Despre";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(131, 26);
            this.toolStripMenuItem2.Text = "Iesire";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(491, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 13;
            // 
            // epDenumire
            // 
            this.epDenumire.ContainerControl = this;
            // 
            // epPublicatie
            // 
            this.epPublicatie.ContainerControl = this;
            // 
            // btnEditare
            // 
            this.btnEditare.Location = new System.Drawing.Point(112, 404);
            this.btnEditare.Name = "btnEditare";
            this.btnEditare.Size = new System.Drawing.Size(117, 44);
            this.btnEditare.TabIndex = 16;
            this.btnEditare.Text = "Editare";
            this.btnEditare.UseVisualStyleBackColor = true;
            this.btnEditare.Click += new System.EventHandler(this.btnEditare_Click);
            // 
            // btnSterge
            // 
            this.btnSterge.Location = new System.Drawing.Point(430, 404);
            this.btnSterge.Name = "btnSterge";
            this.btnSterge.Size = new System.Drawing.Size(117, 44);
            this.btnSterge.TabIndex = 17;
            this.btnSterge.Text = "Am dat\r\n aceasta carte!";
            this.btnSterge.UseVisualStyleBackColor = true;
            this.btnSterge.Click += new System.EventHandler(this.btnSterge_Click);
            // 
            // lvCarte
            // 
            this.lvCarte.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderDenumire,
            this.columnHeaderScriitor,
            this.columnHeaderStare});
            this.lvCarte.HideSelection = false;
            this.lvCarte.Location = new System.Drawing.Point(12, 205);
            this.lvCarte.Name = "lvCarte";
            this.lvCarte.Size = new System.Drawing.Size(662, 180);
            this.lvCarte.TabIndex = 18;
            this.lvCarte.UseCompatibleStateImageBehavior = false;
            this.lvCarte.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderDenumire
            // 
            this.columnHeaderDenumire.Text = "Denumire";
            this.columnHeaderDenumire.Width = 113;
            // 
            // columnHeaderScriitor
            // 
            this.columnHeaderScriitor.Text = "Nume scriitor";
            this.columnHeaderScriitor.Width = 145;
            // 
            // columnHeaderStare
            // 
            this.columnHeaderStare.Text = "Citita/Necitita";
            this.columnHeaderStare.Width = 110;
            // 
            // epStare
            // 
            this.epStare.ContainerControl = this;
            // 
            // FormularCarte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 471);
            this.Controls.Add(this.lvCarte);
            this.Controls.Add(this.btnEditare);
            this.Controls.Add(this.btnSterge);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gbDetalii);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormularCarte";
            this.Text = "Biblioteca mea";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormularCarte_FormClosed);
            this.gbDetalii.ResumeLayout(false);
            this.gbDetalii.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epDenumire)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epPublicatie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epStare)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbDenumire;
        private System.Windows.Forms.TextBox tbScriitor;
        private System.Windows.Forms.Label lblDenumire;
        private System.Windows.Forms.Label lblScriitor;
        private System.Windows.Forms.Label lblStare;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.DateTimePicker dtpPublicatie;
        private System.Windows.Forms.ComboBox cbStare;
        private System.Windows.Forms.Button btnAdauga;
        private System.Windows.Forms.GroupBox gbDetalii;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Menu;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider epDenumire;
        private System.Windows.Forms.ErrorProvider epPublicatie;
        private System.Windows.Forms.Button btnEditare;
        private System.Windows.Forms.ListView lvCarte;
        private System.Windows.Forms.Button btnSterge;
        private System.Windows.Forms.ErrorProvider epStare;
        private System.Windows.Forms.ColumnHeader columnHeaderDenumire;
        private System.Windows.Forms.ColumnHeader columnHeaderScriitor;
        private System.Windows.Forms.ColumnHeader columnHeaderStare;
        private System.Windows.Forms.Button btnElibereazaCampuri;
    }
}

