using JrDev.Models;

namespace JrDev.Services.CharacterService
{
    public interface ICharacterService
    {
        Task<ServiceResponse<List<Character>>> GetAllCharacters();
        Task<ServiceResponse<Character>> GetCharacterById(int id);
        Task<ServiceResponse<List<Character>>> AddCharacter(Character Personaje);
        Task<ServiceResponse<List<Character>>> EditCharacter(Character Personaje);
        Task<ServiceResponse<List<Character>>> DeleteCharacter(int id);
    }
}
