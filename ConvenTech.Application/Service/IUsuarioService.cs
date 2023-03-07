using ConvenTech.Application.Dto;
using System.Linq.Expressions;

namespace ConvenTech.Application.Service
{
    public interface IUsuarioService
    {
        Task<UsuarioDto> CreateAsync(UsuarioDto cliente);
        Task Update(UsuarioDto cliente);
        Task DeleteAsync(UsuarioDto cliente);
        Task<UsuarioDto> GetAsync(Expression<Func<UsuarioDto, bool>> expression);
        Task<IEnumerable<UsuarioDto>> GetAll(UsuarioDto cliente);
        Task<string> ObterTokenJwtAsync(LoginDto dto);
    }
}
