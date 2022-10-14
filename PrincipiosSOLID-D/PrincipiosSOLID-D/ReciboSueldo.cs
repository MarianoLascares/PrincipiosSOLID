using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipiosSOLID_D
{
    public class ReciboSueldo : IImprimible
    {
        public ReciboSueldo(int legajo, double total)
        {
            Legajo = legajo;
            Total = total;
        }
        public int Legajo { get; set; }
        public double Total { get; set; }

        void IImprimible.Imprimir()
        {
            Console.WriteLine($"Imprimiendo recibo de sueldo del legajo {Legajo} por un total de {Total}");
        }
    }
}
