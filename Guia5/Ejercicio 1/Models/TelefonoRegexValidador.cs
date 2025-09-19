using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ejercicio_1.Models
{
    internal class TelefonoRegexValidador : TelefonoCharValidador
    {
        public TelefonoRegexValidador(string expresion) : base(expresion)
        {
        }


        public override bool Validar()
        {
            string pattern  = @"^\d{3,4}\-\d{7}$";


            return Regex.IsMatch(base.expresion , pattern);
        }

        public override string VerMensaje()
        {
            //consultar aca como seria para ahcer polimordismo 

            if(Validar()) { return $"{base.expresion} es valido "; }
            return $"{base.expresion} no es valido";
        }
    }
}
