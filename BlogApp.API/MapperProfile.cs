using AutoMapper;
using BlogApp.Business.DTOs.BrandDTOs;
using BlogApp.Business.DTOs.CarDTOs;
using BlogApp.Core.Entities;

namespace BlogApp.API
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<Brand, CreateBrandDTO>();
            CreateMap<CreateBrandDTO, Brand>();
            CreateMap<Brand, UpdateBrandDTO>();
            CreateMap<UpdateBrandDTO, Brand>();
            CreateMap<Car, CreateCarDTO>();
            CreateMap<CreateCarDTO, Car>();
            CreateMap<Car, UpdateCarDTO>();
            CreateMap<UpdateCarDTO, Car>();
        }
    }
}
