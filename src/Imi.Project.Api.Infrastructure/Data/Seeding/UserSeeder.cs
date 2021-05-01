//using Imi.Project.Api.Core.Entities;
//using Microsoft.EntityFrameworkCore;
//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace Imi.Project.Api.Infrastructure.Data.Seeding
//{
//    public class UserSeeder
//    {
//        public static void Seed(ModelBuilder modelBuilder)
//        {
//            //data courtesy from mockaroo.com
//            modelBuilder.Entity<User>().HasData(
//                new User
//                {
//                    Id = Guid.Parse("00000000-0000-0000-0000-000000000001"),
//                    Name = "Aldwin Geydon",
//                    Email = "ageydon0@marriott.com",
//                    Password = "Ct7JR2FEL",
//                    IsAdmin = true
//                },
//                new User
//                {
//                    Id = Guid.Parse("00000000-0000-0000-0000-000000000002"),
//                    Name = "Clem Woodland",
//                    Email = "cwoodland1@reference.com",
//                    Password = "GwV08icD",
//                    IsRaidLeader = true
//                },
//                new User
//                {
//                    Id = Guid.Parse("00000000-0000-0000-0000-000000000003"),
//                    Name = "Mil Semeniuk",
//                    Email = "msemeniuk2@prweb.com",
//                    Password = "0Sm8bO",
//                    IsRaidLeader = true
//                },
//                new User
//                {
//                    Id = Guid.Parse("00000000-0000-0000-0000-000000000004"),
//                    Name = "Aurel Wasbey",
//                    Email = "awasbey3@google.it",
//                    Password = "YjYpKO",
//                    IsWarlord = true
//                },
//                new User
//                {
//                    Id = Guid.Parse("00000000-0000-0000-0000-000000000005"),
//                    Name = "Jackson Ingyon",
//                    Email = "jingyon4@hao123.com",
//                    Password = "uTyKrtdJ6pk",
//                    IsWarlord = true
//                },
//                new User
//                {
//                    Id = Guid.Parse("00000000-0000-0000-0000-000000000006"),
//                    Name = "Lucho Egell",
//                    Email = "legell5@wikispaces.com",
//                    Password = "U64vxCUx"
//                },
//                new User
//                {
//                    Id = Guid.Parse("00000000-0000-0000-0000-000000000007"),
//                    Name = "Giavani Bortolozzi",
//                    Email = "gbortolozzi6@friendfeed.com",
//                    Password = "4BR3Mr40YsD"
//                },
//                new User
//                {
//                    Id = Guid.Parse("00000000-0000-0000-0000-000000000008"),
//                    Name = "Casie Mair",
//                    Email = "cmair7@dion.ne.jp",
//                    Password = "sPcKvSnIoeEH"
//                },
//                new User
//                {
//                    Id = Guid.Parse("00000000-0000-0000-0000-000000000009"),
//                    Name = "Madalena Rispine",
//                    Email = "mrispine8@is.gd",
//                    Password = "iQYb77c"
//                },
//                new User
//                {
//                    Id = Guid.Parse("00000000-0000-0000-0000-000000000010"),
//                    Name = "Broderick Rowena",
//                    Email = "browena9@springer.com",
//                    Password = "fWs8Sa"
//                },
//                new User
//                {
//                    Id = Guid.Parse("00000000-0000-0000-0000-000000000011"),
//                    Name = "Lenna Gregoriou",
//                    Email = "lgregorioua@storify.com",
//                    Password = "P49llZ049pz"
//                },
//                new User
//                {
//                    Id = Guid.Parse("00000000-0000-0000-0000-000000000012"),
//                    Name = "Timi Eastam",
//                    Email = "teastamb@phoca.cz",
//                    Password = "DfHR3lv2"
//                },
//                new User
//                {
//                    Id = Guid.Parse("00000000-0000-0000-0000-000000000013"),
//                    Name = "Gweneth Lidierth",
//                    Email = "glidierthc@freewebs.com",
//                    Password = "uJd67JjN4tVh"
//                },
//                new User
//                {
//                    Id = Guid.Parse("00000000-0000-0000-0000-000000000014"),
//                    Name = "Lesya Dutton",
//                    Email = "lduttond@canalblog.com",
//                    Password = "2gnClUF8"
//                },
//                new User
//                {
//                    Id = Guid.Parse("00000000-0000-0000-0000-000000000015"),
//                    Name = "Hedvige Fyers",
//                    Email = "hfyerse@dmoz.org",
//                    Password = "L970io8cwz"
//                },
//                new User
//                {
//                    Id = Guid.Parse("00000000-0000-0000-0000-000000000016"),
//                    Name = "Nehemiah Halworth",
//                    Email = "nhalworthf@ezinearticles.com",
//                    Password = "em18c5ls"
//                },
//                new User
//                {
//                    Id = Guid.Parse("00000000-0000-0000-0000-000000000017"),
//                    Name = "Robinetta Phin",
//                    Email = "rphing@europa.eu",
//                    Password = "uRrbRG8co4w"
//                },
//                new User
//                {
//                    Id = Guid.Parse("00000000-0000-0000-0000-000000000018"),
//                    Name = "Correy Dirr",
//                    Email = "cdirrh@ucsd.edu",
//                    Password = "HO5p9jajWl9"
//                },
//                new User
//                {
//                    Id = Guid.Parse("00000000-0000-0000-0000-000000000019"),
//                    Name = "Zelda Ferreras",
//                    Email = "zferrerasi@cisco.com",
//                    Password = "8UV6YqrR"
//                },
//                new User
//                {
//                    Id = Guid.Parse("00000000-0000-0000-0000-000000000020"),
//                    Name = "Paddy Ninnis",
//                    Email = "pninnisj@wix.com",
//                    Password = "1dFoZSvdA"
//                },
//                new User
//                {
//                    Id = Guid.Parse("00000000-0000-0000-0000-000000000021"),
//                    Name = "Jeanna Nind",
//                    Email = "jnindk@github.io",
//                    Password = "s1cRs43a7"
//                },
//                new User
//                {
//                    Id = Guid.Parse("00000000-0000-0000-0000-000000000022"),
//                    Name = "Darius Richford",
//                    Email = "drichfordl@economist.com",
//                    Password = "SebyyqXenu"
//                },
//                new User
//                {
//                    Id = Guid.Parse("00000000-0000-0000-0000-000000000023"),
//                    Name = "Lindy Siebert",
//                    Email = "lsiebertm@mapy.cz",
//                    Password = "5RI8u1feojGH"
//                },
//                new User
//                {
//                    Id = Guid.Parse("00000000-0000-0000-0000-000000000024"),
//                    Name = "Micheil Baxstare",
//                    Email = "mbaxstaren@mysql.com",
//                    Password = "2xhK9m1599T5"
//                },
//                new User
//                {
//                    Id = Guid.Parse("00000000-0000-0000-0000-000000000025"),
//                    Name = "Terrance Klainer",
//                    Email = "tklainero@admin.ch",
//                    Password = "VbJgKJIIHVJo"
//                },
//                new User
//                {
//                    Id = Guid.Parse("00000000-0000-0000-0000-000000000026"),
//                    Name = "Killian Lockless",
//                    Email = "klocklessp@un.org",
//                    Password = "Z6st864D"
//                },
//                new User
//                {
//                    Id = Guid.Parse("00000000-0000-0000-0000-000000000027"),
//                    Name = "Reynold Gabby",
//                    Email = "rgabbyq@mozilla.org",
//                    Password = "VcaYtXSUXm"
//                },
//                new User
//                {
//                    Id = Guid.Parse("00000000-0000-0000-0000-000000000028"),
//                    Name = "Opaline Barta",
//                    Email = "obartar@vistaprint.com",
//                    Password = "XW1MzRu"
//                },
//                new User
//                {
//                    Id = Guid.Parse("00000000-0000-0000-0000-000000000029"),
//                    Name = "Concettina Scocroft",
//                    Email = "cscocrofts@facebook.com",
//                    Password = "GzsICdL08z"
//                },
//                new User
//                {
//                    Id = Guid.Parse("00000000-0000-0000-0000-000000000030"),
//                    Name = "Pooh Shill",
//                    Email = "pshillt@simplemachines.org",
//                    Password = "Hmb5OnSOKr"
//                }
//            );
//        }
//    }
//}
