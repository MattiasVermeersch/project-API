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
            CreateMap<CharacterRequestDto, Character>();

            //Mapping for Arena entity
            CreateMap<Arena, ArenaResponseDto>()
                .ForMember(dest => dest.Mode,
                    opt => opt.MapFrom(src => src.ArenaCharacters.Count()))
                .ForMember(dest => dest.Characters,
                    opt => opt.MapFrom(src => src.ArenaCharacters
                        .Select(ac => new CharacterResponseDto
                        {
                            Id = ac.CharacterId,
                            Name = ac.Character.Name,
                            Class = ac.Character.Class,
                            Role = ac.Character.Role,
                            Level = ac.Character.Level,
                            ItemLevel = ac.Character.ItemLevel,
                            ArenaRating = ac.Character.ArenaRating,
                            BattlegroundRating = ac.Character.BattlegroundRating
                        })));
            CreateMap<ArenaRequestDto, Arena>();

            //Mapping for Battleground entity
            CreateMap<Battleground, BattlegroundResponseDto>()
                .ForMember(dest => dest.Mode,
                    opt => opt.MapFrom(src => src.BattlegroundCharacters.Count() + 1))
                .ForMember(dest => dest.Characters,
                    opt => opt.MapFrom(src => src.BattlegroundCharacters
                        .Select(bc => new CharacterResponseDto
                        {
                            Id = bc.CharacterId,
                            Name = bc.Character.Name,
                            Class = bc.Character.Class,
                            Role = bc.Character.Role,
                            Level = bc.Character.Level,
                            ItemLevel = bc.Character.ItemLevel,
                            ArenaRating = bc.Character.ArenaRating,
                            BattlegroundRating = bc.Character.BattlegroundRating
                        })));
            CreateMap<BattlegroundRequestDto, Battleground>();

            //Mapping for Dungeon entity
            CreateMap<Dungeon, DungeonResponseDto>()
                .ForMember(dest => dest.Characters,
                    opt => opt.MapFrom(src => src.DungeonCharacters
                        .Select(dc => new CharacterResponseDto
                        {
                            Id = dc.CharacterId,
                            Name = dc.Character.Name,
                            Class = dc.Character.Class,
                            Role = dc.Character.Role,
                            Level = dc.Character.Level,
                            ItemLevel = dc.Character.ItemLevel,
                            ArenaRating = dc.Character.ArenaRating,
                            BattlegroundRating = dc.Character.BattlegroundRating
                        })));
            CreateMap<DungeonRequestDto, Dungeon>();

            //Mapping for Raid entity
            CreateMap<Raid, RaidResponseDto>()
                .ForMember(dest => dest.Characters,
                    opt => opt.MapFrom(src => src.RaidCharacters
                        .Select(rc => new CharacterResponseDto
                        {
                            Id = rc.CharacterId,
                            Name = rc.Character.Name,
                            Class = rc.Character.Class,
                            Role = rc.Character.Role,
                            Level = rc.Character.Level,
                            ItemLevel = rc.Character.ItemLevel,
                            ArenaRating = rc.Character.ArenaRating,
                            BattlegroundRating = rc.Character.BattlegroundRating
                        })));
            CreateMap<RaidRequestDto, Raid>();
        }
    }
}
