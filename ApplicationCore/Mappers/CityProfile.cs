using AutoMapper;
using BusinessLayer.Dtos.CityEntity;
using DataAccess.Entities;

namespace CitiesApi.Profiles
{
    public class CityProfile : Profile
    {
        public CityProfile()
        {
            CreateMap<City, CityWithoutPointsOfInterestDto>();
            CreateMap<City, CityDto>();
            CreateMap<CityDto, City>();
        }
    }
}
