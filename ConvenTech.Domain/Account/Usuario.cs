using ConvenTech.CrossCutting.BaseEntity;
using ConvenTech.CrossCutting.Utils;
using ConvenTech.Domain.Account.Enums;
using ConvenTech.Domain.Client;
using ConvenTech.Domain.Validator;
using ConvenTech.Domain.ValueObject;
using FluentValidation;


namespace ConvenTech.Domain.Account
{
    public class Usuario : Entity<Guid>
    {
        public string Nome { get; set; }
        public Email Email { get; set; }
        public Password Password { get; set; }
        public TipoUsuarioEnum TipoUsuario { get; set; }
        public virtual IList<Cliente> Clientes { get; set; }
        public void SetPassword()
        {
            this.Password.Valor = SecurityUtils.HashSHA1(this.Password.Valor);
        }

        public void Validate() =>
            new UsuarioValidator().ValidateAndThrow(this);

        public void Update(string nome, Email email, Password password, TipoUsuarioEnum tipoUsuario)
        {
            Nome = nome;
            Email = email;
            Password = password;
            TipoUsuario = tipoUsuario;
        }
    }
}
