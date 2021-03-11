using Imi.Project.Api.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Imi.Project.Api.Infrastructure.Data.Seeding
{
    public class RaidSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Raid>().HasData(
                new Raid
                {
                    Id = Guid.Parse("10000000-0000-0000-0000-000000000000"),
                    InstanceName = "Caste Nathria",
                    AvailableBosses = 10,
                    Difficulty = "Heroic",
                    Date = new DateTime(2021, 02, 28),
                    LeaderId = Guid.Parse("00000000-0000-0000-0024-000000000000"),
                    BossesKilled = 10
                },
                new Raid
                {
                    Id = Guid.Parse("20000000-0000-0000-0000-000000000000"),
                    InstanceName = "Caste Nathria",
                    AvailableBosses = 10,
                    Difficulty = "Heroic",
                    Date = new DateTime(2021, 03, 07),
                    LeaderId = Guid.Parse("00000000-0000-0000-0024-000000000000"),
                    BossesKilled = 10
                },
                new Raid
                {
                    Id = Guid.Parse("30000000-0000-0000-0000-000000000000"),
                    InstanceName = "Caste Nathria",
                    AvailableBosses = 10,
                    Difficulty = "Heroic",
                    Date = new DateTime(2021, 03, 10),
                    LeaderId = Guid.Parse("00000000-0000-0000-0024-000000000000"),
                    BossesKilled = 10
                }
            );
        }
    }
}
