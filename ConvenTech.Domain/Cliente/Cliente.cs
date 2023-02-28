using ConvenTech.Domain.Cliente.ValueObjects;
using ConvenTech.CrossCutting.Repository;

namespace ConvenTech.Domain.Cliente
{
    public abstract class Cliente: Entity<Guid>
    {
        public string Nome { get; protected set; }
        public Endereco Endereco { get; protected set; }
        public abstract string TipoDocumento { get; }
        protected Cliente(string nome, Endereco endereco)
        {
            Nome = nome;
            Endereco = endereco;  
        }
    }        

}
