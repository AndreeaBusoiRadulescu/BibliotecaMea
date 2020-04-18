using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaMea.Clase
{
    class Revista : EntitatiCitibile
    {
        public override void acordareNota(int nota)
        {
            //nota pentru revista este intre 1 si 5 puncte
            if (nota <= 1 && nota >= 5)
            {
                this.nota = nota;
            }
        }
    }
}
