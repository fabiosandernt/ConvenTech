using AutoMapper;
using ConvenTech.Application.Dto;
using ConvenTech.CrossCutting.JwtService.Contracts;
using ConvenTech.Domain.Account;
using ConvenTech.Domain.Account.Repository;
using System.Linq.Expressions;

namespace ConvenTech.Application.Service
{
    public class UsuarioService: IUsuarioService
    {
        private readonly IUsuarioRepository _usuarioRepository;
        private readonly IMapper _mapper;
        private readonly IJwtService _jwtService;

        public UsuarioService(
            IUsuarioRepository usuarioRepository, 
            IMapper mapper,
            IJwtService jwtService)
        {
            this._usuarioRepository = usuarioRepository;
            this._mapper = mapper;
            this._jwtService = jwtService;
        }

        public async Task<UsuarioDto> CreateAsync(UsuarioDto dto)
        {
            if (await _usuarioRepository.AnyAsync(x => x.Email.Valor == dto.Email.Valor))
                throw new Exception("Já existe um usuário cadastrado com o email informado");

            var usuario = this._mapper.Map<Usuario>(dto);

            usuario.Validate();
            usuario.SetPassword();

            usuario.Id = Guid.NewGuid();

            await _usuarioRepository.Save(usuario);

            return this._mapper.Map<UsuarioDto>(usuario);
        }

        public Task DeleteAsync(UsuarioDto cliente)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<UsuarioDto>> GetAll(UsuarioDto cliente)
        {
            throw new NotImplementedException();
        }

        public Task<UsuarioDto> GetAsync(Expression<Func<UsuarioDto, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Task<string> ObterTokenJwtAsync(LoginDto dto)
        {
            throw new NotImplementedException();
        }

        public Task Update(UsuarioDto cliente)
        {
            throw new NotImplementedException();
        }
    }
}
