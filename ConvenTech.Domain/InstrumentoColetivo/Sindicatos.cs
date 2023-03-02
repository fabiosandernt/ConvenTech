using ConvenTech.CrossCutting.BaseEntity;
using ConvenTech.Domain.ValueObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvenTech.Domain.InstrumentoColetivo
{
    public class Sindicatos: Entity<Guid>
    {
        public TipoSindicatoEnum TipoSindicato { get; set; }    
        public string RazaoSocial { get; set; }
        public Cnpj Cnpj { get; set; }
    }
}
