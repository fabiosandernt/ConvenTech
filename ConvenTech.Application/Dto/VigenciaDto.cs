using ConvenTech.Domain.InstrumentoColetivo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvenTech.Application.Dto
{
    public class VigenciaDto
    {
        public int Id { get; set; }
        public string DataInicio { get; set; }
        public string DataFim { get; set; }
        public ConvencaoColetivaDto ConvencaoColetiva { get; set; }
    }
}
