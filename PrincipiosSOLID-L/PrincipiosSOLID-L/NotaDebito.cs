﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipiosSOLID_L
{
    public class NotaDebito : DocumentoContable
    {
        public NotaDebito(int numero, DateTime fecha) : base(numero, fecha)
        {
            _sigla = "ND";
        }
    }
}
