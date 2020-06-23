using AutoMapper;
using MyMusic.API.Resources;
using MyMusic.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyMusic.API.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            //Domain to Resource
            CreateMap<Music, MusicResource>();
            CreateMap<Artist, ArtistResource>();
            CreateMap<Music, SaveResourceMusic>();

            //Resource to Domain
            CreateMap<MusicResource, Music>();
            CreateMap<ArtistResource, Artist>();
            CreateMap<SaveResourceMusic, Music>();
        }
    }
}