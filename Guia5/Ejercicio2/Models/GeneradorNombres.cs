using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2.Models
{
    static class GeneradorNombres
    {
        static List<string> apellidos = new List<string> { "Hernandez", "Saavedra", "Acosta", "Jacob", "Heinze", "Fischer", "Campos "};
        static List<string> nombres = new List<string> { "Adriana", "Elizabet", "José", "María", "Ernesto", "Sebastian", "Julio", "Ester", "Ariel", "Betiana", "Silvina", "Ana", "Leandro", "Ayelen"," Daniela", "Miguel "};

        static Random rnd = new Random();

        static public string GenerarNombre()
        {
            int a = rnd.Next(0,apellidos.Count);
            int n = rnd.Next(0,nombres.Count);

            return ($"{apellidos[a]} {nombres[n]}");
        }
    }
}
