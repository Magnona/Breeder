using System;
using AutoMapper;
using Breeder.Common.Dto;
using DatabaseAccess.Entities;

namespace Breeder.Framework.Mappings
{
    public class PetMapping : IMapping
    {
        public void ConfigureMaps(IMapperConfigurationExpression mapper)
        {
            mapper.CreateMap<Pet, PetDto>().ForMember(x => x.HasPicture, m => m.Ignore());
            mapper.CreateMap<PetDto, Pet>();

            mapper.CreateMap<Breed, BreedDto>();
            mapper.CreateMap<BreedDto, Breed>();

            mapper.CreateMap<Color, ColorDto>();
            mapper.CreateMap<ColorDto, Color>();

            mapper.CreateMap<Photo, PhotoDto>();
            mapper.CreateMap<PhotoDto, Photo>();

            mapper.CreateMap<Video, VideoDto>();
            mapper.CreateMap<VideoDto, Video>();

            mapper.CreateMap<Status, StatusDto>();
            mapper.CreateMap<StatusDto, Status>();
        }
    }
}
