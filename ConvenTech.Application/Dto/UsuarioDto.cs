using ConvenTech.Domain.Account.Enums;
using ConvenTech.Domain.ValueObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvenTech.Application.Dto
{
    public class UsuarioDto
    {    
        public string Nome { get; set; }
        public Email Email { get; set; }
        public Password Password { get; set; }
        public TipoUsuarioEnum TipoUsuario { get; set; }
    }
}
