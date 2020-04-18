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
    public partial class FormularCarte : Form
    {
        public FormularCarte()
        {
            InitializeComponent();

            //valoare default pe necitit pentru cbStare
            cbStare.SelectedIndex = 1;
        }

        List<Carte> lista = new List<Carte>();

        #region MenuBar

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nume autor: Busoi-Rdulescu Andreea:)");
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region ErrorProviders

        private void tbDenumire_Validated_1(object sender, EventArgs e)
        {
            epDenumire.Clear();
        }

        private void tbDenumire_Validating_1(object sender, CancelEventArgs e)
        {
            String value = tbDenumire.Text;
            if (String.IsNullOrEmpty(value) || String.IsNullOrWhiteSpace(value))
            {
                epDenumire.SetError((Control)sender, "Completeaza denumire!");
                e.Cancel = true; // impiedica utilizatorul sa schimbe controlul
            }
        }

        private void dtpPublicatie_Validated(object sender, EventArgs e)
        {
            epPublicatie.Clear();
        }

        private void dtpPublicatie_Validating(object sender, CancelEventArgs e)
        {
            DateTime dataPublicatie = dtpPublicatie.Value;
            string dateInput = "Jan 1, 1800";
            DateTime parsedDate = DateTime.Parse(dateInput);

            if (DateTime.Compare(dataPublicatie, DateTime.Today) > 0 || DateTime.Compare(dataPublicatie, parsedDate) < 0)
            {
                epPublicatie.SetError(dtpPublicatie, "Data pentru publicatie invalida!");
                e.Cancel = true;
            }
        }

        private void cbStare_Validated(object sender, EventArgs e)
        {
            epStare.Clear();
        }

        private void cbStare_Validating(object sender, CancelEventArgs e)
        {
            if (cbStare.SelectedItem == null)
            {
                epStare.SetError(cbStare, "Introduceti stare!");
                e.Cancel = true;
            }
        }

        #endregion

        #region Metode

        public void umpleBiblotecaCuCarti()
        {
            // stergere ce apare in list view
            lvCarte.Items.Clear();

            //parcurgem lista si adaugare in list view ca String
            foreach (Carte each in lista)
            {
                ListViewItem elementCarte = new ListViewItem(new String[] { each.denumire, each.scriitor, each.stare.ToString() });
                lvCarte.Items.Add(elementCarte);
            }

        }

        void ElibereazaCampuri()
        {
            tbDenumire.Clear();
            tbScriitor.Clear();
            dtpPublicatie.Value = DateTime.Now;
            cbStare.SelectedIndex = 1; //pentru a mentine valoare default "necitita"
        }

        #endregion 

        #region Operatii CRUD

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            bool validare = true;

            String denumire = tbDenumire.Text;
            if (String.IsNullOrEmpty(denumire) || String.IsNullOrWhiteSpace(denumire))
            {
                validare = false;
            }

            String scriitor = tbScriitor.Text;
            if (String.IsNullOrEmpty(scriitor) || String.IsNullOrWhiteSpace(scriitor))
            {
                validare = false;
            }

            DateTime publicatie = dtpPublicatie.Value;
            string dateInput = "Jan 1, 1800";
            DateTime parsedDate = DateTime.Parse(dateInput);
            if (DateTime.Compare(publicatie, DateTime.Today) >= 0 || DateTime.Compare(publicatie, parsedDate) < 0)
            {
                validare = false;
            }

            //Enum.TryParse(cbStare.Text, out Stare stare);
            Stare stare;
            bool semafor = cbStare.Text.Equals("citita");
            if (semafor)
            {
                stare = Stare.CITIT;
            }
            else
            {
                stare = Stare.NECITIT;
            }

            if (validare)
            {
                try
                {
                    Carte carte = new Carte(denumire, scriitor, publicatie, stare);

                    lista.Add(carte);

                    umpleBiblotecaCuCarti();

                    //spatii necompletate formular
                    ElibereazaCampuri();
                }
                catch
                {
                    MessageBox.Show("Probleme la scriere in lista");
                }
            }
        }

        private void btnElibereazaCampuri_Click(object sender, EventArgs e)
        {
            ElibereazaCampuri();
        }

        private void btnSterge_Click(object sender, EventArgs e)
        {
                if (lvCarte.SelectedItems.Count != 0)
                {
                    if (MessageBox.Show("Ai daruit aceasta carte cuiva?", "Stergere din biblioteca",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        lista.RemoveAt(lvCarte.SelectedIndices[0]);
                        umpleBiblotecaCuCarti();
                    }
            }
        }

        private void btnEditare_Click(object sender, EventArgs e)
        {
            if (lvCarte.SelectedItems.Count != 0)
            {
                Carte carte = lista.ElementAt(lvCarte.SelectedIndices[0]);
                //deschidere formular Editare
                Editare editare = new Editare(carte);
                editare.ShowDialog();

                umpleBiblotecaCuCarti();
            }
            else
            {
                MessageBox.Show("Va rugam sa selectati cartea careia doriti sa-i editati specificatiile!");
            }
        }

        #endregion

        private void FormularCarte_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}