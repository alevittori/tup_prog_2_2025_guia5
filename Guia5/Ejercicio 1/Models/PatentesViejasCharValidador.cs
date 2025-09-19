using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1.Models
{
    internal class PatentesViejasCharValidador:Validador
    {
        public PatentesViejasCharValidador(string expresion) :base(expresion) { }

        public override bool Validar()
        {
            //correcta en formato viejo xxx xxx donde el primero grupo es de la a-z y el segundo son digitos del 0-9
            

            //separamos la expresion en dos grupos 
            string[] partes = base.expresion.Split(' ', (char)StringSplitOptions.RemoveEmptyEntries);
            //descartamos si se formao mas de dos grupos
            if(partes.Length != 2) { return false; }
            string letras = partes[0];
            string numeros = partes[1];

            //que ambas partes sean de 3
            if (letras.Length != 3 || numeros.Length != 3) { return false; }

            //ahora validamos las partes
            if (!letras.All(char.IsLetter) || !numeros.All(char.IsDigit)) { return false; }

            return true;

            
        }

        public override string VerMensaje()
        {
           
            if (Validar()) { return $"{base.expresion} patente valida"; }
            return $"{base.expresion} patenta NO valida";
        }
    }
}
