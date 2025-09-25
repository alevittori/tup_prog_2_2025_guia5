using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ejercicio3.Models
{
    internal class Multa :IImportable
    {
        public double Importe { get; private set; }
        public Multa() { }
        public Multa(double importe) // aca dice importe, importe de plata? o el archivo xml ? 
        {
            Importe = importe;
        }
        public override string ToString()
        {
            return $"Importe de la multa {Importe:c}";
        }

        public bool Importar(string xml)
        {
            Match MatchImporte = Regex.Match(xml, "<importe>(.*?)</importe>",RegexOptions.Singleline);
            if (MatchImporte.Success)
            {
                Importe = Convert.ToDouble(MatchImporte.Groups[1].Value);
                return true;
            }
            return false;
        }
    }
}
