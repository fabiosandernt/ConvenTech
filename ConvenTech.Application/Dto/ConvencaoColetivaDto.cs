using ConvenTech.Domain.InstrumentoColetivo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvenTech.Application.Dto
{
    public class ConvencaoColetivaDto
    {
        public string NumeroRegistro { get; set; }
        public string NumeroProcesso { get; set; }
        public string NumeroSolicitacao { get; set; }
        public string SindicatoTrabalhador { get; set; }
        public string SindicatoPatronal { get; set; }
        public string TipoInstrumentoColetivo { get; set; }
        public ICollection<VigenciaDto> Vigencias { get; set; }
    }
}
