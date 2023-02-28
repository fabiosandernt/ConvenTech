using ConvenTech.CrossCutting.Repository;

namespace ConvenTech.Domain.Usuario
{
    public class Usuario : Entity<Guid>
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
