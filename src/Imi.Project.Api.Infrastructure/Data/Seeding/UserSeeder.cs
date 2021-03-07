using Imi.Project.Api.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Imi.Project.Api.Infrastructure.Data.Seeding
{
    public class UserSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User { 
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000001"), 
                    Name = "Martin Foler", 
                    Email = "martin.foler@mail.com", 
                    Password = "MartinF@2021"
                },
                new User { 
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000002"), 
                    Name = "Suzy Galliger", 
                    Email = "suzy.galliger@mail.com", 
                    Password = "SuzyG@2021", 
                    IsAdmin=true 
                },
                new User { 
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000003"), 
                    Name = "Natasha Romanov", 
                    Email = "n.romanov@avengers.com", 
                    Password = "BruceHulkyBrenner" 
                },
                new User { 
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000004"), 
                    Name = "Clark Joseph Kent", 
                    Email = "superman@justiceleague.com", 
                    Password = "Kal-El@DeadKrypton", 
                    IsRaidLeader=true 
                },
                new User { 
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000005"), 
                    Name = "Bruce Wayne", 
                    Email = "brucewayne@wayne.com", 
                    Password = "IamBatman" 
                },
                new User { 
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000006"), 
                    Name = "Tom Gemini", 
                    Email = "Tgemini@mail.com", 
                    Password = "Gemini@2021"
                },
                new User { 
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000007"), 
                    Name = "Geralt of Rivia", 
                    Email = "geralt@witcher.com", 
                    Password = "Yennefer123"
                },
                new User { 
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000008"), 
                    Name = "Gandalf", 
                    Email = "Olorin@aman.com", 
                    Password = "TrueWhiteWizard", 
                    IsWarlord = true 
                },
                new User { 
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000009"), 
                    Name = "Aragorn", 
                    Email = "Ellesar@gondor.com", 
                    Password = "Anduril@FlameOfTheWest" 
                },
                new User { 
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000010"), 
                    Name = "Captain America", 
                    Email = "capt.america", 
                    Password = "PeggyCarter" 
                }
            );
        }
    }
}
