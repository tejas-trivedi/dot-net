using AutoMapper;
using MagicVilla_VillaAPI.Model;
using MagicVilla_VillaAPI.Models.Dto;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MagicVilla_VillaAPI
{
    public class MappingConfig : Profile
    {
        public MappingConfig()
        {
            CreateMap<Villa, VillaDTO>();
            CreateMap<VillaDTO, Villa>();

            CreateMap<Villa, VillaCreateDTO>().ReverseMap();
            CreateMap<Villa, VillaUpdateDTO>().ReverseMap();
        }
    }
}