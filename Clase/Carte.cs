using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotecaMea.Clase
{
    public class Carte : EntitatiCitibile
    {
        //constructor
        public Carte(String denumire, String scriitor, DateTime publicatie, Stare stare)
        {
            this.denumire = denumire;
            this.scriitor = scriitor;
            this.publicatie = publicatie;
            bool semafor = stare.Equals(Stare.CITIT);
            if (semafor)
            {
                this.stare = Stare.CITIT;
            }
            else
            {
                this.stare = Stare.NECITIT;
            }
        }

        public override void acordareNota(int nota)
        {
            if (nota >= 1 && nota <= 10)
            {
                this.nota = nota;
            }
            else
            {
                throw new CustomExceptionNota();
            }
        }

    }
}
