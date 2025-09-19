using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ejercicio_1.Models
{
    internal class PatentesViejasRegexValidador:Validador
    {
        public PatentesViejasRegexValidador(string expresion ): base(expresion) { }

        public override bool Validar()
        {
            string pattern = @"^[a-zA-Z]{3}\s[0-9]{3}$";
            return Regex.IsMatch( base.expresion, pattern );
            
        }


        public override string VerMensaje()
        {
            if(Validar()) return $"{base.expresion} Patente Valida";
            return $"{base.expresion} Patente NO Valida";
        }
    }
}
