using Imi.Project.Api.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Imi.Project.Api.Infrastructure.Data.Seeding
{
    public class BattlegroundCharacterSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BattlegroundCharacter>().HasData(
                //first bg, 9 characters + leader = 10
                new BattlegroundCharacter
                {
                    BattlegroundId = Guid.Parse("00000000-0000-0001-0000-000000000000"),
                    CharacterId = Guid.Parse("00000000-0000-0000-0002-000000000000")
                },
                new BattlegroundCharacter
                {
                    BattlegroundId = Guid.Parse("00000000-0000-0001-0000-000000000000"),
                    CharacterId = Guid.Parse("00000000-0000-0000-0003-000000000000")
                },
                new BattlegroundCharacter
                {
                    BattlegroundId = Guid.Parse("00000000-0000-0001-0000-000000000000"),
                    CharacterId = Guid.Parse("00000000-0000-0000-0004-000000000000")
                },
                new BattlegroundCharacter
                {
                    BattlegroundId = Guid.Parse("00000000-0000-0001-0000-000000000000"),
                    CharacterId = Guid.Parse("00000000-0000-0000-0005-000000000000")
                },
                new BattlegroundCharacter
                {
                    BattlegroundId = Guid.Parse("00000000-0000-0001-0000-000000000000"),
                    CharacterId = Guid.Parse("00000000-0000-0000-0006-000000000000")
                },
                new BattlegroundCharacter
                {
                    BattlegroundId = Guid.Parse("00000000-0000-0001-0000-000000000000"),
                    CharacterId = Guid.Parse("00000000-0000-0000-0007-000000000000")
                },
                new BattlegroundCharacter
                {
                    BattlegroundId = Guid.Parse("00000000-0000-0001-0000-000000000000"),
                    CharacterId = Guid.Parse("00000000-0000-0000-0008-000000000000")
                },
                new BattlegroundCharacter
                {
                    BattlegroundId = Guid.Parse("00000000-0000-0001-0000-000000000000"),
                    CharacterId = Guid.Parse("00000000-0000-0000-0009-000000000000")
                },
                new BattlegroundCharacter
                {
                    BattlegroundId = Guid.Parse("00000000-0000-0001-0000-000000000000"),
                    CharacterId = Guid.Parse("00000000-0000-0000-0010-000000000000")
                },
              
                //second bg, same 9 chars
                new BattlegroundCharacter
                {
                    BattlegroundId = Guid.Parse("00000000-0000-0002-0000-000000000000"),
                    CharacterId = Guid.Parse("00000000-0000-0000-0002-000000000000")
                },
                new BattlegroundCharacter
                {
                    BattlegroundId = Guid.Parse("00000000-0000-0002-0000-000000000000"),
                    CharacterId = Guid.Parse("00000000-0000-0000-0003-000000000000")
                },
                new BattlegroundCharacter
                {
                    BattlegroundId = Guid.Parse("00000000-0000-0002-0000-000000000000"),
                    CharacterId = Guid.Parse("00000000-0000-0000-0004-000000000000")
                },
                new BattlegroundCharacter
                {
                    BattlegroundId = Guid.Parse("00000000-0000-0002-0000-000000000000"),
                    CharacterId = Guid.Parse("00000000-0000-0000-0005-000000000000")
                },
                new BattlegroundCharacter
                {
                    BattlegroundId = Guid.Parse("00000000-0000-0002-0000-000000000000"),
                    CharacterId = Guid.Parse("00000000-0000-0000-0006-000000000000")
                },
                new BattlegroundCharacter
                {
                    BattlegroundId = Guid.Parse("00000000-0000-0002-0000-000000000000"),
                    CharacterId = Guid.Parse("00000000-0000-0000-0007-000000000000")
                },
                new BattlegroundCharacter
                {
                    BattlegroundId = Guid.Parse("00000000-0000-0002-0000-000000000000"),
                    CharacterId = Guid.Parse("00000000-0000-0000-0008-000000000000")
                },
                new BattlegroundCharacter
                {
                    BattlegroundId = Guid.Parse("00000000-0000-0002-0000-000000000000"),
                    CharacterId = Guid.Parse("00000000-0000-0000-0009-000000000000")
                },
                new BattlegroundCharacter
                {
                    BattlegroundId = Guid.Parse("00000000-0000-0002-0000-000000000000"),
                    CharacterId = Guid.Parse("00000000-0000-0000-0010-000000000000")
                },
               
                //third bg, same 9 chars
                new BattlegroundCharacter
                {
                    BattlegroundId = Guid.Parse("00000000-0000-0003-0000-000000000000"),
                    CharacterId = Guid.Parse("00000000-0000-0000-0002-000000000000")
                },
                new BattlegroundCharacter
                {
                    BattlegroundId = Guid.Parse("00000000-0000-0003-0000-000000000000"),
                    CharacterId = Guid.Parse("00000000-0000-0000-0003-000000000000")
                },
                new BattlegroundCharacter
                {
                    BattlegroundId = Guid.Parse("00000000-0000-0003-0000-000000000000"),
                    CharacterId = Guid.Parse("00000000-0000-0000-0004-000000000000")
                },
                new BattlegroundCharacter
                {
                    BattlegroundId = Guid.Parse("00000000-0000-0003-0000-000000000000"),
                    CharacterId = Guid.Parse("00000000-0000-0000-0005-000000000000")
                },
                new BattlegroundCharacter
                {
                    BattlegroundId = Guid.Parse("00000000-0000-0003-0000-000000000000"),
                    CharacterId = Guid.Parse("00000000-0000-0000-0006-000000000000")
                },
                new BattlegroundCharacter
                {
                    BattlegroundId = Guid.Parse("00000000-0000-0003-0000-000000000000"),
                    CharacterId = Guid.Parse("00000000-0000-0000-0007-000000000000")
                },
                new BattlegroundCharacter
                {
                    BattlegroundId = Guid.Parse("00000000-0000-0003-0000-000000000000"),
                    CharacterId = Guid.Parse("00000000-0000-0000-0008-000000000000")
                },
                new BattlegroundCharacter
                {
                    BattlegroundId = Guid.Parse("00000000-0000-0003-0000-000000000000"),
                    CharacterId = Guid.Parse("00000000-0000-0000-0009-000000000000")
                },
                new BattlegroundCharacter
                {
                    BattlegroundId = Guid.Parse("00000000-0000-0003-0000-000000000000"),
                    CharacterId = Guid.Parse("00000000-0000-0000-0010-000000000000")
                },

                //fourth bg, 7 same characters, two different
                new BattlegroundCharacter
                {
                    BattlegroundId = Guid.Parse("00000000-0000-0004-0000-000000000000"),
                    CharacterId = Guid.Parse("00000000-0000-0000-0002-000000000000")
                },
                new BattlegroundCharacter
                {
                    BattlegroundId = Guid.Parse("00000000-0000-0004-0000-000000000000"),
                    CharacterId = Guid.Parse("00000000-0000-0000-0003-000000000000")
                },
                new BattlegroundCharacter
                {
                    BattlegroundId = Guid.Parse("00000000-0000-0004-0000-000000000000"),
                    CharacterId = Guid.Parse("00000000-0000-0000-0004-000000000000")
                },
                new BattlegroundCharacter
                {
                    BattlegroundId = Guid.Parse("00000000-0000-0004-0000-000000000000"),
                    CharacterId = Guid.Parse("00000000-0000-0000-0005-000000000000")
                },
                new BattlegroundCharacter
                {
                    BattlegroundId = Guid.Parse("00000000-0000-0004-0000-000000000000"),
                    CharacterId = Guid.Parse("00000000-0000-0000-0006-000000000000")
                },
                new BattlegroundCharacter
                {
                    BattlegroundId = Guid.Parse("00000000-0000-0004-0000-000000000000"),
                    CharacterId = Guid.Parse("00000000-0000-0000-0007-000000000000")
                },
                new BattlegroundCharacter
                {
                    BattlegroundId = Guid.Parse("00000000-0000-0004-0000-000000000000"),
                    CharacterId = Guid.Parse("00000000-0000-0000-0008-000000000000")
                },
                new BattlegroundCharacter
                {
                    BattlegroundId = Guid.Parse("00000000-0000-0004-0000-000000000000"),
                    CharacterId = Guid.Parse("00000000-0000-0000-0030-000000000000")
                },
                new BattlegroundCharacter
                {
                    BattlegroundId = Guid.Parse("00000000-0000-0004-0000-000000000000"),
                    CharacterId = Guid.Parse("00000000-0000-0000-0000-000000000010")
                },

                //fifth bg, same 9 characters as fourth
                new BattlegroundCharacter
                {
                    BattlegroundId = Guid.Parse("00000000-0000-0005-0000-000000000000"),
                    CharacterId = Guid.Parse("00000000-0000-0000-0002-000000000000")
                },
                new BattlegroundCharacter
                {
                    BattlegroundId = Guid.Parse("00000000-0000-0005-0000-000000000000"),
                    CharacterId = Guid.Parse("00000000-0000-0000-0003-000000000000")
                },
                new BattlegroundCharacter
                {
                    BattlegroundId = Guid.Parse("00000000-0000-0005-0000-000000000000"),
                    CharacterId = Guid.Parse("00000000-0000-0000-0004-000000000000")
                },
                new BattlegroundCharacter
                {
                    BattlegroundId = Guid.Parse("00000000-0000-0005-0000-000000000000"),
                    CharacterId = Guid.Parse("00000000-0000-0000-0005-000000000000")
                },
                new BattlegroundCharacter
                {
                    BattlegroundId = Guid.Parse("00000000-0000-0005-0000-000000000000"),
                    CharacterId = Guid.Parse("00000000-0000-0000-0006-000000000000")
                },
                new BattlegroundCharacter
                {
                    BattlegroundId = Guid.Parse("00000000-0000-0005-0000-000000000000"),
                    CharacterId = Guid.Parse("00000000-0000-0000-0007-000000000000")
                },
                new BattlegroundCharacter
                {
                    BattlegroundId = Guid.Parse("00000000-0000-0005-0000-000000000000"),
                    CharacterId = Guid.Parse("00000000-0000-0000-0008-000000000000")
                },
                new BattlegroundCharacter
                {
                    BattlegroundId = Guid.Parse("00000000-0000-0005-0000-000000000000"),
                    CharacterId = Guid.Parse("00000000-0000-0000-0030-000000000000")
                },
                new BattlegroundCharacter
                {
                    BattlegroundId = Guid.Parse("00000000-0000-0005-0000-000000000000"),
                    CharacterId = Guid.Parse("00000000-0000-0000-0000-000000000010")
                }
            );
        }
    }
}
