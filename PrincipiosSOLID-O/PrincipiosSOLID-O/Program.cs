using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipiosSOLID_O
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DocumentoContable factura = new Factura(46546);
            Console.WriteLine(factura.Descripcion());
            DocumentoContable notaCredito = new NotaCredito(23124);
            Console.WriteLine(notaCredito.Descripcion());
            DocumentoContable notaDebito = new NotaDebito(33124);
            Console.WriteLine(notaDebito.Descripcion());
            Console.ReadKey();
        }
    }
}
