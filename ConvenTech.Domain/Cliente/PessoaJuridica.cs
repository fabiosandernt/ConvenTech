using ConvenTech.Domain.Cliente.ValueObjects;


namespace ConvenTech.Domain.Cliente
{
    public class PessoaJuridica : Cliente
    {
        public Cnpj Cnpj { get; private set; }
        public override string TipoDocumento => "PJ";
        public PessoaJuridica(string nome, Endereco endereco, Cnpj cnpj) : base(nome, endereco)
        {
            Cnpj = cnpj;            
        }
    }
}
