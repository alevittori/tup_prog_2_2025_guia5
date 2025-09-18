using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1.Models
{
    internal class TelefonoCharValidador : Validador
    {


        public TelefonoCharValidador(string expresion) : base(expresion)
        {
        }

        public override bool Validar()
        {
            throw new NotImplementedException();
        }

        public override string VerMensaje()
        {
            return base.VerMensaje();
        }
        
    }
}
