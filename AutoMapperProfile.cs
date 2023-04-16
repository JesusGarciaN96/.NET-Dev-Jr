using AutoMapper;
using JrDev.Dtos.Character;
using JrDev.Models;

namespace JrDev
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Character, GetCharacterDto>();
            CreateMap<AddCharacterDto, Character>();
        }
    }
}
