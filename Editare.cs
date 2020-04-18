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
    public partial class Editare : Form
    {
        Carte instance;
        public Editare(Carte carte)
        {
            InitializeComponent();
            instance = carte;
        }

        private void btnAnulare_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
            instance.denumire = tbDenumire.Text;
            instance.scriitor = tbScriitor.Text;
            bool semafor = cbStare.Text.Equals("citita");
            if (semafor)
            {
                instance.stare = Stare.CITIT;
            }
            else
            {
                instance.stare = Stare.NECITIT;
            }
            this.Close();
        }

        private void Editare_Load(object sender, EventArgs e)
        {
            tbDenumire.Text = instance.denumire;
            tbScriitor.Text = instance.scriitor;
            dtpPublicatie.Value = instance.publicatie;
            cbStare.Text = instance.stare.ToString();
        }
    }
}
