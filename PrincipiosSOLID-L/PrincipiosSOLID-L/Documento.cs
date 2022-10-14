using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace PrincipiosSOLID_L
{
    public abstract class DocumentoContable
    {
        protected string _sigla;
        public DocumentoContable(int numero, DateTime fecha)
        {
            Numero = numero;
            Fecha = fecha;
        }
        public int Numero { get; set; }
        public DateTime Fecha { get; set; }

        public string Imprimir()
        {
            return $"Imprimiendo {Descripcion()}";
        }

        public virtual string Descripcion()
        {
            return $"{_sigla} nro {Numero} de fecha {Fecha.ToShortDateString()}";
        }
    }
}
