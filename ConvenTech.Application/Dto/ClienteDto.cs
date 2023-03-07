using ConvenTech.Domain.Plano;
using ConvenTech.Domain.ValueObject;

namespace ConvenTech.Application.Dto
{
    public class ClienteDto
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public Endereco Endereco { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public PlanoEnum Plano { get; set; }
        public Guid UsuarioId { get; set; }
        public UsuarioDto Usuario { get; set; }
    }
}
