using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipiosSOLID_D
{
    public class NotaCredito : DocumentoContable
    {
        public NotaCredito(int numero, DateTime fecha, double importe):base(numero,fecha,importe)
        {
            _sigla = "NC";
        }

        public override void Imprimir()
        {
            Console.WriteLine($"Imprimiendo Nota de Credito {Numero} del {Fecha} por un importe de {Importe}");
        }

        public override double Total()
        {
            return Importe * 1.21 * -1; //Ejemplo
        }
    }
}
