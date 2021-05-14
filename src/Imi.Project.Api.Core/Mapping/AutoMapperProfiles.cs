using AutoMapper;
using Imi.Project.Api.Core.Dtos;
using Imi.Project.Api.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Imi.Project.Api.Core.Mapping
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            //Mapping for User entity
            CreateMap<User, UserResponseDto>();
            CreateMap<RegisterUserRequestDto, User>();
            CreateMap<UserRequestDto, User>();

            //Mapping for Character entity
            CreateMap<Character, CharacterResponseDto>()
                .ForMember(dest => dest.ArenaCount,
                    opt => opt.MapFrom(src => src.ArenaCharacters.Count()))
                .ForMember(dest => dest.BattlegroundCount,
                    opt => opt.MapFrom(src => src.BattlegroundCharacters.Count()))
                .ForMember(dest => dest.DungeonCount,
                    opt => opt.MapFrom(src => src.DungeonCharacters.Count()))
                .ForMember(dest => dest.RaidCount,
                    opt => opt.MapFrom(src => src.RaidCharacters.Count()));
            CreateMap<Character, SimpleCharacterResponseDto>();
            CreateMap<CharacterRequestDto, Character>();

            //Mapping for Arena entity
            CreateMap<Arena, ArenaResponseDto>()
                .ForMember(dest => dest.Mode,
                    opt => opt.MapFrom(src => src.ArenaCharacters.Count()))
                .ForMember(dest => dest.Characters,
                    opt => opt.MapFrom(src => src.ArenaCharacters
                        .Select(ac => new SimpleCharacterResponseDto
                        {
                            Id = ac.CharacterId,
                            Name = ac.Character.Name,
                            Class = ac.Character.Class,
                            Role = ac.Character.Role,
                            ItemLevel = ac.Character.ItemLevel
                        })));
            CreateMap<ArenaRequestDto, Arena>();

            //Mapping for Battleground entity
            CreateMap<Battleground, BattlegroundResponseDto>()
                .ForMember(dest => dest.Mode,
                    opt => opt.MapFrom(src => src.BattlegroundCharacters.Count() + 1))
                .ForMember(dest => dest.Characters,
                    opt => opt.MapFrom(src => src.BattlegroundCharacters
                        .Select(bc => new SimpleCharacterResponseDto
                        {
                            Id = bc.CharacterId,
                            Name = bc.Character.Name,
                            Class = bc.Character.Class,
                            Role = bc.Character.Role,
                            ItemLevel = bc.Character.ItemLevel
                        })));
            CreateMap<BattlegroundRequestDto, Battleground>();

            //Mapping for Dungeon entity
            CreateMap<Dungeon, DungeonResponseDto>()
                .ForMember(dest => dest.Characters,
                    opt => opt.MapFrom(src => src.DungeonCharacters
                        .Select(dc => new SimpleCharacterResponseDto
                        {
                            Id = dc.CharacterId,
                            Name = dc.Character.Name,
                            Class = dc.Character.Class,
                            Role = dc.Character.Role,
                            ItemLevel = dc.Character.ItemLevel
                        })));
            CreateMap<DungeonRequestDto, Dungeon>();

            //Mapping for Raid entity
            CreateMap<Raid, RaidResponseDto>()
                .ForMember(dest => dest.Characters,
                    opt => opt.MapFrom(src => src.RaidCharacters
                        .Select(rc => new SimpleCharacterResponseDto
                        {
                            Id = rc.CharacterId,
                            Name = rc.Character.Name,
                            Class = rc.Character.Class,
                            Role = rc.Character.Role,
                            ItemLevel = rc.Character.ItemLevel
                        })));
            CreateMap<RaidRequestDto, Raid>();
        }
    }
}
