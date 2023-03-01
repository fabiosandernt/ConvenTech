using ConvenTech.CrossCutting.JwtService.Dto;
using ConvenTech.CrossCutting.JwtService.ViewModel;


namespace ConvenTech.CrossCutting.JwtService.Contracts
{
    public interface IJwtService
    {
        ValueTask<string> GenerateToken(JwtDto jwtDto);
        ValueTask<JwtTokenViewModel> ReadTokenAsync(string token);
    }
}
