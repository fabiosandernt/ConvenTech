using ConvenTech.CrossCutting.BaseEntity;
using ConvenTech.Domain.ValueObject;


namespace ConvenTech.Domain.Cliente
{
    public class Cliente : Entity<Guid>
    {
        public string Nome { get; private set; }
        public Endereco Endereco { get; private set; }
        public string Telefone { get; private set; }
        public Email Email { get; private set; }
        public Password Password { get; private set; }        
        public PlanoEnum Plano { get; set; }    
       
    }
}
