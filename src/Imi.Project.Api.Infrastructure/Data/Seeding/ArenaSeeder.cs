using Imi.Project.Api.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Imi.Project.Api.Infrastructure.Data.Seeding
{
    public class ArenaSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Arena>().HasData(
                new Arena
                {
                    Id = Guid.Parse("00000000-0001-0000-0000-000000000000"),
                    Date = new DateTime(2021, 02, 12),
                    LeaderId = Guid.Parse("00000000-0000-0000-0010-000000000000"),
                    IsWon = true
                },
                new Arena
                {
                    Id = Guid.Parse("00000000-0002-0000-0000-000000000000"),
                    Date = new DateTime(2021, 02, 12),
                    LeaderId = Guid.Parse("00000000-0000-0000-0010-000000000000"),
                    IsWon = true
                },
                new Arena
                {
                    Id = Guid.Parse("00000000-0003-0000-0000-000000000000"),
                    Date = new DateTime(2021, 02, 12),
                    LeaderId = Guid.Parse("00000000-0000-0000-0010-000000000000"),
                    IsWon = false
                },
                new Arena
                {
                    Id = Guid.Parse("00000000-0004-0000-0000-000000000000"),
                    Date = new DateTime(2021, 02, 12),
                    LeaderId = Guid.Parse("00000000-0000-0000-0010-000000000000"),
                    IsWon = true
                },
                new Arena
                {
                    Id = Guid.Parse("00000000-0005-0000-0000-000000000000"),
                    Date = new DateTime(2021, 02, 13),
                    LeaderId = Guid.Parse("00000000-0000-0000-0018-000000000000"),
                    IsWon = false
                },
                new Arena
                {
                    Id = Guid.Parse("00000000-0006-0000-0000-000000000000"),
                    Date = new DateTime(2021, 02, 13),
                    LeaderId = Guid.Parse("00000000-0000-0000-0018-000000000000"),
                    IsWon = false
                },
                new Arena
                {
                    Id = Guid.Parse("00000000-0007-0000-0000-000000000000"),
                    Date = new DateTime(2021, 02, 13),
                    LeaderId = Guid.Parse("00000000-0000-0000-0018-000000000000"),
                    IsWon = true
                },
                new Arena
                {
                    Id = Guid.Parse("00000000-0008-0000-0000-000000000000"),
                    Date = new DateTime(2021, 02, 13),
                    LeaderId = Guid.Parse("00000000-0000-0000-0018-000000000000"),
                    IsWon = false
                },
                new Arena
                {
                    Id = Guid.Parse("00000000-0009-0000-0000-000000000000"),
                    Date = new DateTime(2021, 02, 13),
                    LeaderId = Guid.Parse("00000000-0000-0000-0018-000000000000"),
                    IsWon = false
                },
                new Arena
                {
                    Id = Guid.Parse("00000000-0010-0000-0000-000000000000"),
                    Date = new DateTime(2021, 02, 13),
                    LeaderId = Guid.Parse("00000000-0000-0000-0018-000000000000"),
                    IsWon = false
                }
            );
        }
    }
}
