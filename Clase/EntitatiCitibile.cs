using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaMea.Clase
{
    public abstract class EntitatiCitibile
    {
        public String denumire;
        public String scriitor;
        public DateTime publicatie;
        public Stare stare;
        private int numarPagini;
        public int nota;

        public abstract void acordareNota(int n);
    }
}
