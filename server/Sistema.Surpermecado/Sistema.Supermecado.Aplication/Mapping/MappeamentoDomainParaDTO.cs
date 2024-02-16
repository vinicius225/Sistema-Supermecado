using AutoMapper;
using Sistema.Supermecado.Aplication.DTOs;
using Sistema.Supermecado.Domain.Entities;

namespace Sistema.Supermecado.Aplication.Mapping
{
    public class MappeamentoDomainParaDTO : Profile
    {
        public MappeamentoDomainParaDTO()
        {
            CreateMap<Usuario, UsuarioDTO>().ReverseMap();
            CreateMap<Usuario, UsuarioAlteracaoDTO>().ReverseMap();
        }
    }
}
