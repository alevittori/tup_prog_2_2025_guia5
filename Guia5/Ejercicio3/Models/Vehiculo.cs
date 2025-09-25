using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ejercicio3.Models
{
    internal class Vehiculo:IImportable,IComparable<Vehiculo>
    {
        List<Multa> multas = new List<Multa>();
        public string Patente {  get; private set; }
        public int CantidadMultas { get { return multas.Count; } private set { } }
        public double ImporteTotal { 
            get
            {
                double total = 0;
                foreach (Multa multa in multas)
                {
                    total += multa.Importe;
                }
                return total;
            }
                
                 private set { } }
        public Vehiculo() { }
        public Vehiculo(string patente)
        {
            Patente = patente;
            
        }
        public Multa VerMulta(int idx)
        {
            if (idx > 0 && idx < multas.Count)
            {
                return multas[idx];
            }
            return null;

        }
        public void AgregarMulta(Multa multa) { if(multa != null ) multas.Add(multa); }

        public bool Importar(string xml)
        {
            bool ret = false;
            //aca deberia hacer la implementacion de controlar que la patente sea la del vehiculo
            MatchCollection todasMultas = Regex.Matches(xml, @"<multa>(.*?)</multa>",RegexOptions.Singleline);

            //ahora recorro multa por multa y comparo, si la patente es la misma que this.Patente , creo nueva multa , y la guardo en this.multas

            foreach (Match m in todasMultas)
            {
                if (m.Success) 
                {
                    //extraigo la pantente
                    Match patente = Regex.Match(m.Value, @"<patente>(.*?)</patente>");
                    if (patente.Success)
                    {
                        string p = patente.Groups[1].Value; 
                        if(p.ToUpper() == this.Patente.ToUpper()) //por las dudas lo paso a mayusculas para comparar
                        {
                            //saco el importe
                            Match importeMatch = Regex.Match(m.Value, @"<importe>(.*?)</importe>");
                            if (importeMatch.Success)
                            {
                                double importe = Convert.ToDouble(importeMatch.Groups[1].Value); // creo que aca puede saltar chocolate jaja
                                Multa nueva = new Multa(importe);
                                // multas.Add(nueva); // lo agrego a la lista de multas
                                AgregarMulta(nueva);
                                ret =  true;

                            }


                        }
                    }
                }

            }



            return ret;
            
        }

        public override string ToString()
        {
            return $"Vehiculo Patente {Patente} - Importe Total a pagar: {ImporteTotal}";
        }

        public int CompareTo(Vehiculo other)
        {
            return this.Patente.CompareTo(other.Patente);
        }
    }
}
