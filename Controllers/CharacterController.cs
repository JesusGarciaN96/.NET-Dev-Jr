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

        [HttpGet]
        public ActionResult<IEnumerable<Character>> GetAll()
        { 
            return Ok(Personajes);
        }

        [HttpGet("{id}")]
        public ActionResult<Character> Get(int id)
        {
            return Ok(Personajes.FirstOrDefault(per => per.Id == id));
        }

        [HttpPost]
        public ActionResult<IEnumerable<Character>> Post(Character Personaje)
        {
            if(Personaje != null)
            {
                Personajes.Add(Personaje);
                return Ok(Personajes);
            }
            return NotFound();
        }

        [HttpPut]
        public ActionResult<IEnumerable<Character>> Put(Character Personaje)
        {
            if (Personaje == null)
            {
                return NotFound();
            }

            int indicePersonaje = Personajes.FindIndex(per => per.Id == Personaje.Id);
            if(indicePersonaje > 0)
            {
                Personajes[indicePersonaje] = Personaje;
                return Ok(Personajes);
            }
            return NotFound();
        }

        [HttpDelete("{id}")]
        public ActionResult<IEnumerable<Character>> Delete(int id)
        {
            int indicePersonaje = Personajes.FindIndex(pr => pr.Id == id);
            if(indicePersonaje > 0)
            {
                Personajes.RemoveAt(indicePersonaje);
                return Ok(Personajes);
            }
            return NotFound();
        }
    }
}
