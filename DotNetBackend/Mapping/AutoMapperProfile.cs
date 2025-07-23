using AutoMapper;
using DotNetBackend.Models;
using DotNetBackend.DTOs;

namespace DotNetBackend.Mapping {
  public class AutoMapperProfile : Profile {
    public AutoMapperProfile() {
      CreateMap<Product, ProductDTO>().ReverseMap();
    }
  }
}
