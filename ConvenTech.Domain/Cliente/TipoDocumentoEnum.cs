﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvenTech.Domain.Cliente
{
    public enum TipoDocumentoEnum
    {    
        [Description("Pessoa Física")]
        Fisica = 0,

        [Description("Pessoa Jurídica")]
        Juridica = 1,
    }
}
