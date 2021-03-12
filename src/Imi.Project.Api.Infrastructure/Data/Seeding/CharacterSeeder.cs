using Imi.Project.Api.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Imi.Project.Api.Infrastructure.Data.Seeding
{
    public class CharacterSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Character>().HasData(
                new Character { 
                    Id = Guid.Parse("00000000-0000-0000-0001-000000000000"), 
                    Name = "Ghortak",
                    Class = "Death Knight",
                    Role = "Tank",
                    Level = 60,
                    ItemLevel = 167,
                    ArenaRating = 0,
                    BattlegroundRating = 0,
                    UserId = Guid.Parse("00000000-0000-0000-0000-000000000001")
                },
                new Character
                {
                    Id = Guid.Parse("00000000-0000-0000-0002-000000000000"),
                    Name = "Bauglir",
                    Class = "Druid",
                    Role = "Dps",
                    Level = 60,
                    ItemLevel = 216,
                    ArenaRating = 0,
                    BattlegroundRating = 0,
                    UserId = Guid.Parse("00000000-0000-0000-0000-000000000001")
                },
                new Character
                {
                    Id = Guid.Parse("00000000-0000-0000-0003-000000000000"),
                    Name = "Shiroe",
                    Class = "Priest",
                    Role = "Healer",
                    Level = 60,
                    ItemLevel = 131,
                    ArenaRating = 384,
                    BattlegroundRating = 192,
                    UserId = Guid.Parse("00000000-0000-0000-0000-000000000001")
                },
                new Character
                {
                    Id = Guid.Parse("00000000-0000-0000-0004-000000000000"),
                    Name = "Yoriko",
                    Class = "Shaman",
                    Role = "Healer",
                    Level = 60,
                    ItemLevel = 216,
                    ArenaRating = 0,
                    BattlegroundRating = 0,
                    UserId = Guid.Parse("00000000-0000-0000-0000-000000000002")
                },
                new Character
                {
                    Id = Guid.Parse("00000000-0000-0000-0005-000000000000"),
                    Name = "Elen",
                    Class = "Warlock",
                    Role = "Dps",
                    Level = 60,
                    ItemLevel = 149,
                    ArenaRating = 0,
                    BattlegroundRating = 0,
                    UserId = Guid.Parse("00000000-0000-0000-0000-000000000002")
                },
                new Character
                {
                    Id = Guid.Parse("00000000-0000-0000-0006-000000000000"),
                    Name = "Tary",
                    Class = "Mage",
                    Role = "Dps",
                    Level = 60,
                    ItemLevel = 187,
                    ArenaRating = 0,
                    BattlegroundRating = 0,
                    UserId = Guid.Parse("00000000-0000-0000-0000-000000000002")
                },
                new Character
                {
                    Id = Guid.Parse("00000000-0000-0000-0007-000000000000"),
                    Name = "Borugor",
                    Class = "Warrior",
                    Role = "Dps",
                    Level = 60,
                    ItemLevel = 175,
                    ArenaRating = 0,
                    BattlegroundRating = 0,
                    UserId = Guid.Parse("00000000-0000-0000-0000-000000000003")
                },
                new Character
                {
                    Id = Guid.Parse("00000000-0000-0000-0008-000000000000"),
                    Name = "Wildstrider",
                    Class = "Hunter",
                    Role = "Dps",
                    Level = 60,
                    ItemLevel = 196,
                    ArenaRating = 0,
                    BattlegroundRating = 0,
                    UserId = Guid.Parse("00000000-0000-0000-0000-000000000003")
                },
                new Character
                {
                    Id = Guid.Parse("00000000-0000-0000-0009-000000000000"),
                    Name = "Liutasil",
                    Class = "Paladin",
                    Role = "Tank",
                    Level = 60,
                    ItemLevel = 200,
                    ArenaRating = 0,
                    BattlegroundRating = 0,
                    UserId = Guid.Parse("00000000-0000-0000-0000-000000000003")
                },
                new Character
                {
                    Id = Guid.Parse("00000000-0000-0000-0010-000000000000"),
                    Name = "Aerenthil",
                    Class = "Demon Hunter",
                    Role = "Dps",
                    Level = 60,
                    ItemLevel = 145,
                    ArenaRating = 0,
                    BattlegroundRating = 0,
                    UserId = Guid.Parse("00000000-0000-0000-0000-000000000004")
                },
                new Character
                {
                    Id = Guid.Parse("00000000-0000-0000-0011-000000000000"),
                    Name = "Ghinin",
                    Class = "Monk",
                    Role = "Tank",
                    Level = 60,
                    ItemLevel = 193,
                    ArenaRating = 0,
                    BattlegroundRating = 0,
                    UserId = Guid.Parse("00000000-0000-0000-0000-000000000004")
                },
                new Character
                {
                    Id = Guid.Parse("00000000-0000-0000-0012-000000000000"),
                    Name = "Nuremor",
                    Class = "Mage",
                    Role = "Dps",
                    Level = 60,
                    ItemLevel = 145,
                    ArenaRating = 0,
                    BattlegroundRating = 0,
                    UserId = Guid.Parse("00000000-0000-0000-0000-000000000004")
                },
                new Character
                {
                    Id = Guid.Parse("00000000-0000-0000-0013-000000000000"),
                    Name = "Rhamanji",
                    Class = "Shaman",
                    Role = "Dps",
                    Level = 60,
                    ItemLevel = 185,
                    ArenaRating = 0,
                    BattlegroundRating = 0,
                    UserId = Guid.Parse("00000000-0000-0000-0000-000000000005")
                },
                new Character
                {
                    Id = Guid.Parse("00000000-0000-0000-0014-000000000000"),
                    Name = "Ebrothil",
                    Class = "Priest",
                    Role = "Dps",
                    Level = 60,
                    ItemLevel = 187,
                    ArenaRating = 0,
                    BattlegroundRating = 0,
                    UserId = Guid.Parse("00000000-0000-0000-0000-000000000005")
                },
                new Character
                {
                    Id = Guid.Parse("00000000-0000-0000-0015-000000000000"),
                    Name = "Tyrigon",
                    Class = "Rogue",
                    Role = "Dps",
                    Level = 60,
                    ItemLevel = 187,
                    ArenaRating = 0,
                    BattlegroundRating = 0,
                    UserId = Guid.Parse("00000000-0000-0000-0000-000000000005")
                },
                new Character
                {
                    Id = Guid.Parse("00000000-0000-0000-0016-000000000000"),
                    Name = "Aeternus",
                    Class = "Paladin",
                    Role = "Healer",
                    Level = 60,
                    ItemLevel = 202,
                    ArenaRating = 0,
                    BattlegroundRating = 0,
                    UserId = Guid.Parse("00000000-0000-0000-0000-000000000006")
                },
                new Character
                {
                    Id = Guid.Parse("00000000-0000-0000-0017-000000000000"),
                    Name = "Trech",
                    Class = "Monk",
                    Role = "Healer",
                    Level = 60,
                    ItemLevel = 201,
                    ArenaRating = 0,
                    BattlegroundRating = 0,
                    UserId = Guid.Parse("00000000-0000-0000-0000-000000000006")
                },
                new Character
                {
                    Id = Guid.Parse("00000000-0000-0000-0018-000000000000"),
                    Name = "Baradhor",
                    Class = "Shaman",
                    Role = "Healer",
                    Level = 60,
                    ItemLevel = 201,
                    ArenaRating = 0,
                    BattlegroundRating = 0,
                    UserId = Guid.Parse("00000000-0000-0000-0000-000000000007")
                },
                new Character
                {
                    Id = Guid.Parse("00000000-0000-0000-0019-000000000000"),
                    Name = "Eranthil",
                    Class = "Druid",
                    Role = "Healer",
                    Level = 60,
                    ItemLevel = 199,
                    ArenaRating = 0,
                    BattlegroundRating = 0,
                    UserId = Guid.Parse("00000000-0000-0000-0000-000000000007")
                },
                new Character
                {
                    Id = Guid.Parse("00000000-0000-0000-0020-000000000000"),
                    Name = "Morgoroth",
                    Class = "Warlock",
                    Role = "Dps",
                    Level = 60,
                    ItemLevel = 139,
                    ArenaRating = 0,
                    BattlegroundRating = 0,
                    UserId = Guid.Parse("00000000-0000-0000-0000-000000000007")
                },
                new Character
                {
                    Id = Guid.Parse("00000000-0000-0000-0021-000000000000"),
                    Name = "Malefikh",
                    Class = "Demon Hunter",
                    Role = "Dps",
                    Level = 60,
                    ItemLevel = 157,
                    ArenaRating = 0,
                    BattlegroundRating = 0,
                    UserId = Guid.Parse("00000000-0000-0000-0000-000000000007")
                },
                new Character
                {
                    Id = Guid.Parse("00000000-0000-0000-0022-000000000000"),
                    Name = "Ashifal",
                    Class = "Death Knight",
                    Role = "Dps",
                    Level = 60,
                    ItemLevel = 187,
                    ArenaRating = 0,
                    BattlegroundRating = 0,
                    UserId = Guid.Parse("00000000-0000-0000-0000-000000000008")
                },
                new Character
                {
                    Id = Guid.Parse("00000000-0000-0000-0023-000000000000"),
                    Name = "Umbrion",
                    Class = "Hunter",
                    Role = "Dps",
                    Level = 60,
                    ItemLevel = 188,
                    ArenaRating = 0,
                    BattlegroundRating = 0,
                    UserId = Guid.Parse("00000000-0000-0000-0000-000000000008")
                },
                new Character
                {
                    Id = Guid.Parse("00000000-0000-0000-0024-000000000000"),
                    Name = "Coolbone",
                    Class = "Mage",
                    Role = "Dps",
                    Level = 60,
                    ItemLevel = 192,
                    ArenaRating = 0,
                    BattlegroundRating = 0,
                    UserId = Guid.Parse("00000000-0000-0000-0000-000000000008")
                },
                new Character
                {
                    Id = Guid.Parse("00000000-0000-0000-0025-000000000000"),
                    Name = "GilGalad",
                    Class = "Warrior",
                    Role = "Tank",
                    Level = 60,
                    ItemLevel = 177,
                    ArenaRating = 0,
                    BattlegroundRating = 0,
                    UserId = Guid.Parse("00000000-0000-0000-0000-000000000009")
                },
                new Character
                {
                    Id = Guid.Parse("00000000-0000-0000-0026-000000000000"),
                    Name = "Yreleth",
                    Class = "Rogue",
                    Role = "Dps",
                    Level = 60,
                    ItemLevel = 169,
                    ArenaRating = 0,
                    BattlegroundRating = 0,
                    UserId = Guid.Parse("00000000-0000-0000-0000-000000000009")
                },
                new Character
                {
                    Id = Guid.Parse("00000000-0000-0000-0027-000000000000"),
                    Name = "Bromir",
                    Class = "Monk",
                    Role = "Dps",
                    Level = 60,
                    ItemLevel = 152,
                    ArenaRating = 0,
                    BattlegroundRating = 0,
                    UserId = Guid.Parse("00000000-0000-0000-0000-000000000009")
                },
                new Character
                {
                    Id = Guid.Parse("00000000-0000-0000-0028-000000000000"),
                    Name = "Phandalor",
                    Class = "Druid",
                    Role = "Healer",
                    Level = 60,
                    ItemLevel = 152,
                    ArenaRating = 0,
                    BattlegroundRating = 0,
                    UserId = Guid.Parse("00000000-0000-0000-0000-000000000010")
                },
                new Character
                {
                    Id = Guid.Parse("00000000-0000-0000-0029-000000000000"),
                    Name = "Myriad",
                    Class = "Hunter",
                    Role = "Dps",
                    Level = 60,
                    ItemLevel = 174,
                    ArenaRating = 0,
                    BattlegroundRating = 0,
                    UserId = Guid.Parse("00000000-0000-0000-0000-000000000010")
                },
                new Character
                {
                    Id = Guid.Parse("00000000-0000-0000-0030-000000000000"),
                    Name = "Ithaela",
                    Class = "Warrior",
                    Role = "Dps",
                    Level = 60,
                    ItemLevel = 210,
                    ArenaRating = 0,
                    BattlegroundRating = 0,
                    UserId = Guid.Parse("00000000-0000-0000-0000-000000000010")
                }
            );
        }
    }
}
