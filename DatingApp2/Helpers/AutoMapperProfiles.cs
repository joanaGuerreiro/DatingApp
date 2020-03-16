using AutoMapper;
using DatingApp2.Dtos;
using DatingApp2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatingApp2.Helpers
{
    public class AutoMapperProfiles: Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<User, UserForListDto>()
                .ForMember(dest => dest.PhotoUrl, opt => {
                    opt.MapFrom(src => src.Photos.FirstOrDefault(p => p.IsMain).Url);
                })
                 .ForMember(dest => dest.Age, opt => {
                     opt.MapFrom(d => d.DateOfBirth.CalulateAge()); }) ; 
            CreateMap<User, UserForDetailedDto>()
                .ForMember(dest => dest.PhotoUrl, opt => {
                opt.MapFrom(src => src.Photos.FirstOrDefault(p => p.IsMain).Url);
            })  
                .ForMember(dest => dest.Age, opt => {
                opt.MapFrom(d => d.DateOfBirth.CalulateAge());
            });
            CreateMap<Photo, PhotosForDetailedDto>();

        }
    }
}
