using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipiosSOLID_I
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Factura factura = new Factura(1232,DateTime.Now);
            factura.CAI = "12312312";

            FacturaElectronica facturaElectronica = new FacturaElectronica(32131,DateTime.Now);
            facturaElectronica.CAI = "32131232";

            facturaElectronica.Imprimir();
            facturaElectronica.EnviarPorEmail();
            factura.Imprimir();
            //factura.EnviarPorEmail();

            Console.ReadKey();
        }
    }
}
