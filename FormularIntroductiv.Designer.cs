namespace BibliotecaMea
{
    partial class FormularIntroductiv
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
            this.lblIntroductiv = new System.Windows.Forms.Label();
            this.btnCarte = new System.Windows.Forms.Button();
            this.btnRevista = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.meniuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.despreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iesireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblIntroductiv
            // 
            this.lblIntroductiv.AutoSize = true;
            this.lblIntroductiv.Location = new System.Drawing.Point(178, 99);
            this.lblIntroductiv.Name = "lblIntroductiv";
            this.lblIntroductiv.Size = new System.Drawing.Size(244, 17);
            this.lblIntroductiv.TabIndex = 0;
            this.lblIntroductiv.Text = "Va rog selectati una dintre cele doua:\r\n";
            // 
            // btnCarte
            // 
            this.btnCarte.Location = new System.Drawing.Point(108, 212);
            this.btnCarte.Name = "btnCarte";
            this.btnCarte.Size = new System.Drawing.Size(106, 50);
            this.btnCarte.TabIndex = 1;
            this.btnCarte.Text = "Carte";
            this.btnCarte.UseVisualStyleBackColor = true;
            this.btnCarte.Click += new System.EventHandler(this.btnCarte_Click);
            // 
            // btnRevista
            // 
            this.btnRevista.Location = new System.Drawing.Point(381, 212);
            this.btnRevista.Name = "btnRevista";
            this.btnRevista.Size = new System.Drawing.Size(106, 50);
            this.btnRevista.TabIndex = 2;
            this.btnRevista.Text = "Revista";
            this.btnRevista.UseVisualStyleBackColor = true;
            this.btnRevista.Click += new System.EventHandler(this.btnRevista_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.meniuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(594, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // meniuToolStripMenuItem
            // 
            this.meniuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.despreToolStripMenuItem,
            this.iesireToolStripMenuItem});
            this.meniuToolStripMenuItem.Name = "meniuToolStripMenuItem";
            this.meniuToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.meniuToolStripMenuItem.Text = "Meniu";
            // 
            // despreToolStripMenuItem
            // 
            this.despreToolStripMenuItem.Name = "despreToolStripMenuItem";
            this.despreToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.despreToolStripMenuItem.Text = "Despre";
            this.despreToolStripMenuItem.Click += new System.EventHandler(this.despreToolStripMenuItem_Click);
            // 
            // iesireToolStripMenuItem
            // 
            this.iesireToolStripMenuItem.Name = "iesireToolStripMenuItem";
            this.iesireToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.iesireToolStripMenuItem.Text = "Iesire";
            this.iesireToolStripMenuItem.Click += new System.EventHandler(this.iesireToolStripMenuItem_Click);
            // 
            // FormularIntroductiv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 322);
            this.Controls.Add(this.btnRevista);
            this.Controls.Add(this.btnCarte);
            this.Controls.Add(this.lblIntroductiv);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormularIntroductiv";
            this.Text = "Biblioteca mea";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIntroductiv;
        private System.Windows.Forms.Button btnCarte;
        private System.Windows.Forms.Button btnRevista;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem meniuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem despreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iesireToolStripMenuItem;
    }
}