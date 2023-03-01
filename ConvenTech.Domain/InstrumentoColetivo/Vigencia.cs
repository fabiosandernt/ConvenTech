

namespace ConvenTech.Domain.InstrumentoColetivo
{
    public class Vigencia
    {
        public int Id { get; set; }
        public string DataInicio { get; set; }
        public string DataFim { get; set; }
        public ConvencaoColetiva ConvencaoColetiva { get; set; }
    }
}
