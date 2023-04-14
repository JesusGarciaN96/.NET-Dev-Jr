using JrDev.Models;

namespace JrDev.Services.CharacterService
{
    public interface ICharacterService
    {
        List<Character> GetAllCharacters();
        Character GetCharacterById(int id);
        List<Character> AddCharacter(Character Personaje);
        List<Character> EditCharacter(Character Personaje);
        List<Character> DeleteCharacter(int id);
    }
}
