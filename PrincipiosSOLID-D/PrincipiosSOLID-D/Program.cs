using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipiosSOLID_D
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Impresora impresora = new Impresora();

            IImprimible factura = new Factura(1234, DateTime.Now, 303);
            IImprimible notaCredito = new NotaCredito(344, DateTime.Now, 400);
            Remito remito = new Remito(5445, DateTime.Now, 5);
            FacturaLuz facturaLuz = new FacturaLuz(411, "4324232");
            Municipal municipal = new Municipal(1233, "534534523");

            Cobranza cobranza = new Cobranza()
            {
                Numero = 443214,
                Importe = 2342
            };

            List<IImprimible> lista = new List<IImprimible>();
            lista.Add(factura);
            lista.Add(notaCredito);
            lista.Add(remito);
            lista.Add(facturaLuz);
            lista.Add(municipal);
            lista.Add(cobranza);

            foreach ( var item in lista)
            {
                impresora.Imprimir(item);
            }

            /*impresora.Imprimir(factura);
            impresora.Imprimir(notaCredito);
            impresora.Imprimir(remito);
            impresora.Imprimir(facturaLuz);
            impresora.Imprimir(municipal);
            impresora.Imprimir(cobranza);*/

            Console.ReadKey();

        }
    }
}
