using ApiMiniSistema.DTOs;
using ApiMiniSistema.Entities;
using AutoMapper;

namespace ApiMiniSistema.Utilities
{
    public class AutoMapperConfig: Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<Productos, ProductosDTO>();
            CreateMap<ProductosDTO, Productos>();
            CreateMap<CreacionProductosDTO, Productos>();
        }
    }
}
