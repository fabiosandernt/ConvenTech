using ConvenTech.CrossCutting.BaseEntity;

namespace ConvenTech.Domain.InstrumentoColetivo
{
    public class ConvencaoColetiva: Entity<Guid>    {

        public string NumeroRegistro { get; set; }
        public string NumeroProcesso { get; set; }
        public string NumeroSolicitacao { get; set; }
        public string SindicatoTrabalhador { get; set; }
        public string SindicatoPatronal { get; set; }
        public string TipoInstrumentoColetivo { get; set; }   
        public ICollection<Vigencia> Vigencias { get; set; }
      
    }
}
