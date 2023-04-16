using JrDev.Models;
using JrDev.Dtos.Character;
using AutoMapper;

namespace JrDev.Services.CharacterService
{
    public class CharacterService : ICharacterService
    {
        private readonly IMapper _mapper;
        private static List<Character> Personajes = new List<Character>
            {
                new Character { Id = 1 },
                new Character { Id = 2, Nombre = "Pedrito", Fuerza = 250, Oficio = RPG.Mago },
                new Character { Id = 3, Nombre = "Daniela", Fuerza = 400, Oficio = RPG.Clero }
            };

        public CharacterService(IMapper mapper)
        {
            _mapper = mapper;
        }

        public async Task<ServiceResponse<List<GetCharacterDto>>> AddCharacter(AddCharacterDto Personaje)
        {
            if (Personaje == null)
            {
                throw new Exception("El personaje no es válido");
            }

            Personajes.Add(_mapper.Map<Character>(Personaje));
            return new ServiceResponse<List<GetCharacterDto>>
            {
                Data = Personajes.Select(pr => _mapper.Map<GetCharacterDto>(pr)).ToList(),
                Message = "Personaje agregado"
            };
        }

        public async Task<ServiceResponse<List<GetCharacterDto>>> GetAllCharacters()
        {
            return new ServiceResponse<List<GetCharacterDto>>
            {
                Data = Personajes.Select(pr => _mapper.Map<GetCharacterDto>(pr)).ToList(),
                Message = "Lista de personajes"
            };
        }

        public async Task<ServiceResponse<GetCharacterDto>> GetCharacterById(int id)
        {
            var personaje = Personajes.FirstOrDefault(pr => pr.Id == id);
            if (personaje is not null)
            {
                return new ServiceResponse<GetCharacterDto>
                {
                    Data = _mapper.Map<GetCharacterDto>(personaje),
                    Message = "Detalle del personaje"
                };
            }
            throw new Exception("No se encontró el personaje");
        }

        public async Task<ServiceResponse<List<GetCharacterDto>>> EditCharacter(GetCharacterDto Personaje)
        {
            if (Personaje == null)
            {
                throw new Exception();
            }

            int indicePersonaje = Personajes.FindIndex(per => per.Id == Personaje.Id);
            if (indicePersonaje > 0)
            {
                Personajes[indicePersonaje] = _mapper.Map<Character>(Personaje);
                return new ServiceResponse<List<GetCharacterDto>>
                {
                    Data = Personajes.Select(pr => _mapper.Map<GetCharacterDto>(pr)).ToList(),
                    Message = "Personaje editado"
                };
            }
            throw new Exception("No se encontró el personaje");
        }

        public async Task<ServiceResponse<List<GetCharacterDto>>> DeleteCharacter(int id)
        {
            int indicePersonaje = Personajes.FindIndex(pr => pr.Id == id);
            if (indicePersonaje > 0)
            {
                Personajes.RemoveAt(indicePersonaje);
                return new ServiceResponse<List<GetCharacterDto>>
                {
                    Data = Personajes.Select(pr => _mapper.Map<GetCharacterDto>(pr)).ToList(),
                    Message = "Personaje eliminado"
                };
            }
            throw new Exception("No se encontró el personaje");
        }
    }
}
