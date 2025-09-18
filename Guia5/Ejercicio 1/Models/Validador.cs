using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1.Models
{
     abstract internal class Validador
    {
        string expresion;

        public Validador(string expresion) 
        {
            this.expresion = expresion;
        }

        abstract public bool Validar();

        virtual public string VerMensaje()
        {
            return expresion;
        }
    }
}
