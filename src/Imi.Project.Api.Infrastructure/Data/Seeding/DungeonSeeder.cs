using Imi.Project.Api.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Imi.Project.Api.Infrastructure.Data.Seeding
{
    public class DungeonSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Dungeon>().HasData(
                new Dungeon
                {
                    Id = Guid.Parse("00000001-0000-0000-0000-000000000000"),
                    InstanceName = "De Other Side",
                    AvailableBosses = 4,
                    Difficulty = "Heroic",
                    Date = new DateTime(2021, 01, 31),
                    //Ithaela
                    LeaderId = Guid.Parse("00000000-0000-0000-0030-000000000000"),
                    Succes = true
                },
                new Dungeon
                {
                    Id = Guid.Parse("00000002-0000-0000-0000-000000000000"),
                    InstanceName = "Mists of Tirna Scithe",
                    AvailableBosses = 3,
                    Difficulty = "Heroic",
                    Date = new DateTime(2021, 01, 31),
                    //Ithaela
                    LeaderId = Guid.Parse("00000000-0000-0000-0030-000000000000"),
                    Succes = true
                }, 
                new Dungeon
                {
                    Id = Guid.Parse("00000003-0000-0000-0000-000000000000"),
                    InstanceName = "The Necrotic Wake",
                    AvailableBosses = 4,
                    Difficulty = "Heroic",
                    Date = new DateTime(2021, 01, 31),
                    //Ithaela
                    LeaderId = Guid.Parse("00000000-0000-0000-0030-000000000000"),
                    Succes = true
                },
                new Dungeon
                {
                    Id = Guid.Parse("00000004-0000-0000-0000-000000000000"),
                    InstanceName = "Plaguefall",
                    AvailableBosses = 4,
                    Difficulty = "Mythic",
                    Date = new DateTime(2021, 01, 31),
                    //Liutasil
                    LeaderId = Guid.Parse("00000000-0000-0000-0009-000000000000"),
                    Succes = true
                },
                new Dungeon
                {
                    Id = Guid.Parse("00000005-0000-0000-0000-000000000000"),
                    InstanceName = "Spires of Ascension",
                    AvailableBosses = 4,
                    Difficulty = "Mythic",
                    Date = new DateTime(2021, 01, 31),
                    //Liutasil
                    LeaderId = Guid.Parse("00000000-0000-0000-0009-000000000000"),
                    Succes = true
                },
                new Dungeon
                {
                    Id = Guid.Parse("00000006-0000-0000-0000-000000000000"),
                    InstanceName = "Halls of Atonement",
                    AvailableBosses = 4,
                    Difficulty = "Mythic+ 5",
                    Date = new DateTime(2021, 02, 02),
                    //Ghinin
                    LeaderId = Guid.Parse("00000000-0000-0000-0011-000000000000"),
                    Succes = true,
                    KeyIncrease = 2
                },
                new Dungeon
                {
                    Id = Guid.Parse("00000007-0000-0000-0000-000000000000"),
                    InstanceName = "Theater of Pain",
                    AvailableBosses = 5,
                    Difficulty = "Mythic+ 7",
                    Date = new DateTime(2021, 02, 02),
                    //Ghinin
                    LeaderId = Guid.Parse("00000000-0000-0000-0011-000000000000"),
                    Succes = true,
                    KeyIncrease = 1
                },
                new Dungeon
                {
                    Id = Guid.Parse("00000008-0000-0000-0000-000000000000"),
                    InstanceName = "Sanguine Depths",
                    AvailableBosses = 5,
                    Difficulty = "Mythic+ 8",
                    Date = new DateTime(2021, 02, 02),
                    //Ghinin
                    LeaderId = Guid.Parse("00000000-0000-0000-0011-000000000000"),
                    Succes = false,
                }
            );
        }
    }
}
