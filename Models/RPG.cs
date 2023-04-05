using System.Text.Json.Serialization;

namespace JrDev.Models
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum RPG
    {
        Caballero = 1,
        Mago,
        Clero
    }
}
