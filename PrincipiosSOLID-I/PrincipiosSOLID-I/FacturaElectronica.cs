using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipiosSOLID_I
{
    internal class FacturaElectronica : Documento, IEmaileable
    {
        public FacturaElectronica(int numero, DateTime fecha) : base(numero, fecha) { }
        public string CAI { get; set; }

        public void EnviarPorEmail()
        {
            Console.WriteLine($"Emviando por email la factura {Numero} del dia {Fecha.ToLongDateString()}");
        }

        public override void Imprimir()
        {
            Console.WriteLine($"Imprimiendo la factura {Numero} del dia {Fecha.ToLongDateString()}");
        }
    }
}
