using JrDev.Models;
using JrDev.Dtos.Character;
using JrDev.Services.CharacterService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JrDev.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CharacterController : ControllerBase
    {
        private readonly ICharacterService _characterService;

        public CharacterController(ICharacterService characterService)
        {
            _characterService = characterService;
        }

        [HttpGet]
        public async Task<ActionResult<ServiceResponse<IEnumerable<GetCharacterDto>>>> GetAll()
        {
            return Ok(await _characterService.GetAllCharacters());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ServiceResponse<GetCharacterDto>>> Get(int id)
        {
            return Ok(await _characterService.GetCharacterById(id));
        }

        [HttpPost]
        public async Task<ActionResult<ServiceResponse<IEnumerable<GetCharacterDto>>>> Post(AddCharacterDto Personaje)
        {
            return Ok(await _characterService.AddCharacter(Personaje));
        }

        [HttpPut]
        public async Task<ActionResult<ServiceResponse<IEnumerable<GetCharacterDto>>>> Put(GetCharacterDto Personaje)
        {
            return Ok(await _characterService.EditCharacter(Personaje));
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<ServiceResponse<IEnumerable<GetCharacterDto>>>> Delete(int id)
        {
            return Ok(await _characterService.DeleteCharacter(id));
        }
    }
}
