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

        /*
            * Exprecion correcata
            * 
            *  2324-2456556
               343-4817427
            
            primero devemos separar el string por el '-'en dos vectores nos deveb quedar dos uno v[3/4] y otro v[7]
            ambos deben contener solo numeros

            */

        public override bool Validar()
        {
            //validamos que no sea cadena vacia
            if (string.IsNullOrEmpty(base.expresion)) { return false; }
            string[] palabras = base.expresion.Split('-'); // creamos un vector separando 
            //validamos que solo sea un vector de dos
            if(palabras.Length != 2 ) { return false; } // con esto validamos que sean solo dos partes
            // validamos que sean de 3 o 4 la primera y de 7 la segunda
            if ((palabras[0].Length < 3 || palabras[0].Length > 4) || palabras[1].Length != 7) { return false; }


            // mejoramos esto
            /*
            for ( int i = 0; i < palabras[0].Length; i++ )
            {
                if (!char.IsNumber(palabras[0][i])) 
                { 
                    return false;
                }
            }
            for( int i = 0;i < palabras[1].Length; i++)
            {
                if (!char.IsNumber(palabras[1][i]))
                {
                    return false;
                }
            }
            */

            //usamos el All para no recorrer caracter por caracter
            if (!palabras[0].All(char.IsDigit) || !palabras[1].All(char.IsDigit)) { return false; }

            // si llego hasta aca es porque esta de la manera correcta
            return true;


        }

        public override string VerMensaje()
        {
            if (Validar()) { return $"{base.expresion} es valido"; }
            return $"{base.expresion} no es valido";
        }
        
    }
}
