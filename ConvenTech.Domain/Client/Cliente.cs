using ConvenTech.CrossCutting.BaseEntity;
using ConvenTech.Domain.Account;
using ConvenTech.Domain.ValueObject;


namespace ConvenTech.Domain.Client
{
    public class Cliente : Entity<Guid>
    {
        public string Nome { get; private set; }
        public Endereco Endereco { get; }
        public string Telefone { get; private set; }
        public Email Email { get; private set; }
        public Password Password { get; private set; }
        public PlanoEnum Plano { get; set; }
        public Guid UsuarioId { get; set; }
        public Usuario Usuario { get; set; }
        public Cliente(string nome, Endereco endereco, string telefone, Email email, Password password, PlanoEnum plano, Guid usuarioId, Usuario usuario)
        {
            Id = Guid.NewGuid();
            Nome = nome;
            Endereco = endereco;
            Telefone = telefone;
            Email = email;
            Password = password;
            Plano = plano;
            UsuarioId = usuarioId;
            Usuario = usuario;
        }

        // Sobrecarga do construtor para permitir que o VO seja fornecido separadamente
        public Cliente(string nome, string logradouro, string numero, string complemento, string bairro, string cidade, string estado, string cep, string telefone, Email email, Password password, PlanoEnum plano, Guid usuarioId, Usuario usuario)
            : this(nome, Endereco.Create(logradouro, numero, complemento, bairro, cidade, estado, cep), telefone, email, password, plano, usuarioId, usuario)
        {

        }
    }
}

