using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipiosSOLID_L
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Impresora impresora = new Impresora();

            Remito remito = new Remito(123, DateTime.Now, 10);
            DocumentoContable factura = new Factura(122, DateTime.Now);
            DocumentoContable notaCredito = new NotaCredito(213, DateTime.Now);
            DocumentoContable notaDebito = new NotaDebito(333, DateTime.Now);

            impresora.ImprimirRemito(remito);
            impresora.ImprimirDocumento(factura);
            impresora.ImprimirDocumento(notaCredito);
            impresora.ImprimirDocumento(notaDebito);

            Console.ReadKey();
        }
    }
}
