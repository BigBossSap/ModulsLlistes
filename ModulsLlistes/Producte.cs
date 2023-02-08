using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BotigaLlistes
{
    class Producte
    {
        public String Nom { set; get; }
        public double Preu_sense_iva { set; get; }
        public double Iva { set; get; }
        public Producte(string nom, double preu, double iva)
        {
            this.Nom = nom;
            this.Preu_sense_iva = preu;
            this.Iva = iva;
        }
        public string toString()
        {
            return "Nom:" + Nom + ", preu: " + Preu_sense_iva + ", iva: " + Iva;
        }
    }
}
