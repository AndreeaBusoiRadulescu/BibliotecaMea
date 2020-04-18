using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BibliotecaMea.Clase;

namespace BibliotecaMea
{
    public partial class FormularRevista : Form
    {

        public FormularRevista()
        {
            InitializeComponent();
        }

        #region Menu Bar
        private void despreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nume autor: Busoi-Rdulescu Andreea:)");
        }

        private void iesireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        private void btnCarte_Click(object sender, EventArgs e)
        {
            FormularCarte carte = new FormularCarte();
            this.Close();
            carte.Show();
        }
    }
}
