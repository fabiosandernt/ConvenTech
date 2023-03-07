using ConvenTech.Domain.InstrumentoColetivo;
using ConvenTech.Domain.ValueObject;

namespace ConvenTech.Application.Dto
{
    public class SindicatoDto
    {
        public TipoSindicatoEnum TipoSindicato { get; set; }
        public string RazaoSocial { get; set; }
        public Cnpj Cnpj { get; set; }
    }
}
