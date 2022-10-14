using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipiosSOLID_D
{
    public class FacturaLuz : Impuesto    
    {
        public FacturaLuz(double importe, string codigoPago) : base(importe)
        {
            CodigoPago = codigoPago;
        }
        public string CodigoPago { get; set; }

        public override void Imprimir()
        {
            Console.WriteLine($"Imprimiendo Factura de luz con código de pago nro {CodigoPago} por un importe de {Importe}");
        }
    }
}
