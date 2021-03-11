using Imi.Project.Api.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Imi.Project.Api.Infrastructure.Data.Seeding
{
    public class ArenaCharacterSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ArenaCharacter>().HasData(
                new ArenaCharacter 
                {                         
                    ArenaId = Guid.Parse("00000000-0001-0000-0000-000000000000"), 
                    CharacterId = Guid.Parse("00000000-0000-0000-0008-000000000000")
                },
                new ArenaCharacter
                {
                    ArenaId = Guid.Parse("00000000-0002-0000-0000-000000000000"),
                    CharacterId = Guid.Parse("00000000-0000-0000-0008-000000000000")
                },
                new ArenaCharacter
                {
                    ArenaId = Guid.Parse("00000000-0003-0000-0000-000000000000"),
                    CharacterId = Guid.Parse("00000000-0000-0000-0008-000000000000")
                },
                new ArenaCharacter
                {
                    ArenaId = Guid.Parse("00000000-0004-0000-0000-000000000000"),
                    CharacterId = Guid.Parse("00000000-0000-0000-0008-000000000000")
                },
                new ArenaCharacter
                {
                    ArenaId = Guid.Parse("00000000-0005-0000-0000-000000000000"),
                    CharacterId = Guid.Parse("00000000-0000-0000-0002-000000000000")
                },
                new ArenaCharacter
                {
                    ArenaId = Guid.Parse("00000000-0005-0000-0000-000000000000"),
                    CharacterId = Guid.Parse("00000000-0000-0000-0005-000000000000")
                },
                new ArenaCharacter
                {
                    ArenaId = Guid.Parse("00000000-0006-0000-0000-000000000000"),
                    CharacterId = Guid.Parse("00000000-0000-0000-0002-000000000000")
                },
                new ArenaCharacter
                {
                    ArenaId = Guid.Parse("00000000-0006-0000-0000-000000000000"),
                    CharacterId = Guid.Parse("00000000-0000-0000-0005-000000000000")
                }, 
                new ArenaCharacter
                {
                    ArenaId = Guid.Parse("00000000-0007-0000-0000-000000000000"),
                    CharacterId = Guid.Parse("00000000-0000-0000-0002-000000000000")
                },
                new ArenaCharacter
                {
                    ArenaId = Guid.Parse("00000000-0007-0000-0000-000000000000"),
                    CharacterId = Guid.Parse("00000000-0000-0000-0005-000000000000")
                },
                new ArenaCharacter
                {
                    ArenaId = Guid.Parse("00000000-0008-0000-0000-000000000000"),
                    CharacterId = Guid.Parse("00000000-0000-0000-0002-000000000000")
                },
                new ArenaCharacter
                {
                    ArenaId = Guid.Parse("00000000-0008-0000-0000-000000000000"),
                    CharacterId = Guid.Parse("00000000-0000-0000-0005-000000000000")
                },
                new ArenaCharacter
                {
                    ArenaId = Guid.Parse("00000000-0009-0000-0000-000000000000"),
                    CharacterId = Guid.Parse("00000000-0000-0000-0002-000000000000")
                },
                new ArenaCharacter
                {
                    ArenaId = Guid.Parse("00000000-0009-0000-0000-000000000000"),
                    CharacterId = Guid.Parse("00000000-0000-0000-0024-000000000000")
                },
                new ArenaCharacter
                {
                    ArenaId = Guid.Parse("00000000-0010-0000-0000-000000000000"),
                    CharacterId = Guid.Parse("00000000-0000-0000-0002-000000000000")
                },
                new ArenaCharacter
                {
                    ArenaId = Guid.Parse("00000000-0010-0000-0000-000000000000"),
                    CharacterId = Guid.Parse("00000000-0000-0000-0024-000000000000")
                }
            );
        }
    }
}
