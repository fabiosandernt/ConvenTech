using AutoMapper;
using ConvenTech.Application.Dto;
using ConvenTech.Domain.Account;

namespace ConvenTech.Application.AutoMapper
{
    public class ConvenTechAutoMapperConfig: Profile
    {
        public ConvenTechAutoMapperConfig()
        {
            CreateMap<Usuario, UsuarioDto>();
            CreateMap<UsuarioDto, Usuario>();
        }
    }
}
