using JrDev.Models;

namespace JrDev.Dtos.Character
{
    public class GetCharacterDto
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = "Juanito";
        public int Puntos { get; set; } = 100;
        public int Fuerza { get; set; } = 10;
        public int Defensa { get; set; } = 10;
        public int Inteligencia { get; set; } = 10;
        public RPG Oficio { get; set; } = RPG.Caballero;
    }
}
