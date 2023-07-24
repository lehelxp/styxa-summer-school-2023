using AutoMapper;
using CityInfo.Entities;
using CityInfo.Models;

namespace CityInfo.Profiles
{
    public class PointOfInterestProfile:Profile
    {
        public PointOfInterestProfile() {
            CreateMap<PointOfInterest, PointOfInterestDto>();
            CreateMap<PointOfInterestDto, PointOfInterest>();
        
        }
    }
}
