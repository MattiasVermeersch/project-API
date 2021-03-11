﻿using System;
using System.Collections.Generic;
using System.Text;
using Imi.Project.Api.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Imi.Project.Api.Infrastructure.Data.Seeding
{
    public class BattlegroundSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Battleground>().HasData(
                new Battleground
                {
                    Id = Guid.Parse("00000000-0000-0001-000-000000000000"),
                    InstanceName = "Warsong Gulch",
                    Date = new DateTime(2021, 03, 01),
                    LeaderId = Guid.Parse("00000000-0000-0000-0022-000000000000"),
                    IsWon = true
                },
                new Battleground
                {
                    Id = Guid.Parse("00000000-0000-0002-000-000000000000"),
                    InstanceName = "Twin Peaks",
                    Date = new DateTime(2021, 03, 01),
                    LeaderId = Guid.Parse("00000000-0000-0000-0022-000000000000"),
                    IsWon = true
                },
                new Battleground
                {
                    Id = Guid.Parse("00000000-0000-0003-000-000000000000"),
                    InstanceName = "Twin Peaks",
                    Date = new DateTime(2021, 03, 01),
                    LeaderId = Guid.Parse("00000000-0000-0000-0022-000000000000"),
                    IsWon = false
                },
                new Battleground
                {
                    Id = Guid.Parse("00000000-0000-0004-000-000000000000"),
                    InstanceName = "Twin Peaks",
                    Date = new DateTime(2021, 03, 01),
                    LeaderId = Guid.Parse("00000000-0000-0000-0022-000000000000"),
                    IsWon = true
                },
                new Battleground
                {
                    Id = Guid.Parse("00000000-0000-0005-000-000000000000"),
                    InstanceName = "Warsong Gulch",
                    Date = new DateTime(2021, 03, 01),
                    LeaderId = Guid.Parse("00000000-0000-0000-0022-000000000000"),
                    IsWon = true
                }
            );
        }
    }
}
