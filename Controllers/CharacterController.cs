using JrDev.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JrDev.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CharacterController : ControllerBase
    {
        private static List<Character> Personajes = new List<Character>
            {
                new Character { Id = 1 },
                new Character { Id = 2, Nombre = "Pedrito", Fuerza = 250, Oficio = RPG.Mago },
                new Character { Id = 3, Nombre = "Daniela", Fuerza = 400, Oficio = RPG.Clero }
            };

        [HttpGet("Characters")]
        public ActionResult<IEnumerable<Character>> GetAll()
        { 
            return Ok(Personajes);
        }

        [HttpGet("Character/{id}")]
        public ActionResult<Character> Get(int id)
        {
            return Ok(Personajes.FirstOrDefault(per => per.Id == id));
        }
    }
}
