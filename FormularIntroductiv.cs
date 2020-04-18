using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotecaMea
{
    public partial class FormularIntroductiv : Form
    {
        public FormularIntroductiv()
        {
            InitializeComponent();
        }

        private void btnCarte_Click(object sender, EventArgs e)
        {
            FormularCarte carte = new FormularCarte();
            carte.Show();
            this.Hide();
        }

        private void btnRevista_Click(object sender, EventArgs e)
        {
            FormularRevista revista = new FormularRevista();
            revista.Show();
            this.Hide();
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

    }
}
