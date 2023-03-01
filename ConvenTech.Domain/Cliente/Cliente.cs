using ConvenTech.CrossCutting.BaseEntity;
using ConvenTech.Domain.ValueObject;

namespace ConvenTech.Domain.Cliente
{
    public abstract class Cliente: Entity<Guid>
    {
        protected Cliente() { }

        public string Nome { get; private set; }
        public Endereco Endereco { get; private set; }
        public string Telefone { get; private set; }
        public Email Email { get; private set; }
        public Identificador Identificador { get; private set; }

        public Cliente(string nome, Endereco endereco, string telefone, Email email, Identificador identificador)
        {
            Id = Guid.NewGuid();
            Nome = nome;
            Endereco = endereco;
            Telefone = telefone;
            Email = email;
            Identificador = identificador;
        }
    }

    public class Identificador
    {
        public string Numero { get; private set; }

        public Identificador(string numero)
        {
            Numero = numero;
        }
    }

    public class PessoaFisica : Cliente
    {
        public string Cpf { get; private set; }

        public PessoaFisica(string nome, Endereco endereco, string telefone, Email email, string cpf) : base(nome, endereco, telefone,  email, new Identificador(cpf))
        {
            Cpf = cpf;
        }
    }

    public class PessoaJuridica : Cliente
    {
        public string Cnpj { get; private set; }

        public PessoaJuridica(string nome, Endereco endereco, string telefone, Email email, string cnpj) : base(nome, endereco, telefone, email, new Identificador(cnpj))
        {
            Cnpj = cnpj;
        }
    }

}
