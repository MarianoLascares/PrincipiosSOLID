using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipiosSOLID_D
{
    public class Impresora
    {
        public void Imprimir(IImprimible imprimible)
        {
            imprimible.Imprimir();
        }
    }
}
