using ConvenTech.Domain.Cliente.ValueObjects;

namespace ConvenTech.Domain.Cliente
{
    public class PessoaFisica : Cliente
    {
        public Cpf Cpf { get; private set; }
        public override string TipoDocumento => "PF";
        public PessoaFisica(string nome, Endereco endereco, Cpf cpf) : base(nome, endereco)
        {
            Cpf = cpf;            
        }
    }
}
