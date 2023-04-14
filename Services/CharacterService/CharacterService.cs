using JrDev.Models;

namespace JrDev.Services.CharacterService
{
    public class CharacterService : ICharacterService
    {
        private static List<Character> Personajes = new List<Character>
            {
                new Character { Id = 1 },
                new Character { Id = 2, Nombre = "Pedrito", Fuerza = 250, Oficio = RPG.Mago },
                new Character { Id = 3, Nombre = "Daniela", Fuerza = 400, Oficio = RPG.Clero }
            };

        public List<Character> AddCharacter(Character Personaje)
        {
            if (Personaje == null)
            {
                throw new Exception();
            }

            Personajes.Add(Personaje);
            return Personajes;
        }

        public List<Character> GetAllCharacters()
        {
            return Personajes;
        }

        public Character GetCharacterById(int id)
        {
            int indicePersonaje = Personajes.FindIndex(pr => pr.Id == id);
            if (indicePersonaje > 0)
            {
                return Personajes[indicePersonaje];
            }
            throw new Exception();
        }

        public List<Character> EditCharacter(Character Personaje)
        {
            if (Personaje == null)
            {
                throw new Exception();
            }

            int indicePersonaje = Personajes.FindIndex(per => per.Id == Personaje.Id);
            if (indicePersonaje > 0)
            {
                Personajes[indicePersonaje] = Personaje;
                return Personajes;
            }
            throw new Exception();
        }

        public List<Character> DeleteCharacter(int id)
        {
            int indicePersonaje = Personajes.FindIndex(pr => pr.Id == id);
            if (indicePersonaje > 0)
            {
                Personajes.RemoveAt(indicePersonaje);
                return Personajes;
            }
            throw new Exception();
        }
    }
}
