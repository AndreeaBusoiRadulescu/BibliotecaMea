using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaMea.Clase
{
    class CustomExceptionNota : Exception
    {
        public override string Message
        {
            get { return "Notele sunt intre 1 si 10 inclusiv!"; }
        }
    }
}
