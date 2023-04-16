using JrDev.Models;
using JrDev.Dtos.Character;

namespace JrDev.Services.CharacterService
{
    public interface ICharacterService
    {
        Task<ServiceResponse<List<GetCharacterDto>>> GetAllCharacters();
        Task<ServiceResponse<GetCharacterDto>> GetCharacterById(int id);
        Task<ServiceResponse<List<GetCharacterDto>>> AddCharacter(AddCharacterDto Personaje);
        Task<ServiceResponse<List<GetCharacterDto>>> EditCharacter(GetCharacterDto Personaje);
        Task<ServiceResponse<List<GetCharacterDto>>> DeleteCharacter(int id);
    }
}
