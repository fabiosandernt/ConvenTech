using ConvenTech.CrossCutting.BaseEntity;
using ConvenTech.CrossCutting.Utils;
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
        
        public void SetPassword()
        {
            this.Password.Valor = SecurityUtils.HashSHA1(this.Password.Valor);
        }

        public void Validate() =>
            new UsuarioValidator().ValidateAndThrow(this);
    }
}
