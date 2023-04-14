using JrDev.Models;
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
        public ActionResult<IEnumerable<Character>> GetAll()
        {
            return Ok(_characterService.GetAllCharacters());
        }

        [HttpGet("{id}")]
        public ActionResult<Character> Get(int id)
        {
            return Ok(_characterService.GetCharacterById(id));
        }

        [HttpPost]
        public ActionResult<IEnumerable<Character>> Post(Character Personaje)
        {
            return Ok(_characterService.AddCharacter(Personaje));
        }

        [HttpPut]
        public ActionResult<IEnumerable<Character>> Put(Character Personaje)
        {
            return Ok(_characterService.EditCharacter(Personaje));
        }

        [HttpDelete("{id}")]
        public ActionResult<IEnumerable<Character>> Delete(int id)
        {
            return Ok(_characterService.DeleteCharacter(id));
        }
    }
}
