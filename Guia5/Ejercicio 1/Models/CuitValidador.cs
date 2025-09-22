using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ejercicio_1.Models
{
    internal class CuitValidador : Validador
    {
        public CuitValidador(string expresion) : base(expresion)
        {
        }

        public override bool Validar()
        {
            // Paso 1: Validar formato con Regex
            string patron = @"^(\d{2})-(\d{8})-(\d{1})$";
            Match match = Regex.Match(base.expresion, patron);

            if (!match.Success)
                return false;

            // Paso 2: Extraer los grupos
            string tipo = match.Groups[1].Value;
            string numero = match.Groups[2].Value;
            string verificador = match.Groups[3].Value;

            string cuitSinGuiones = tipo + numero;

            // Paso 3: Calcular dígito verificador
            int[] pesos = { 5, 4, 3, 2, 7, 6, 5, 4, 3, 2 };
            int suma = 0;

            for (int i = 0; i < pesos.Length; i++)
            {
                suma += int.Parse(cuitSinGuiones[i].ToString()) * pesos[i];
            }

            int resto = suma % 11;
            int digitoCalculado = resto == 0 ? 0 : resto == 1 ? 9 : 11 - resto;

            // Paso 4: Comparar con el dígito real
            return digitoCalculado == int.Parse(verificador);
        }
        public override string VerMensaje()
        {
            if (Validar()) { return $"{base.expresion} CUIT Valido"; }
            return $"{base.expresion} CUIT NO valido";
        }
    }
}
