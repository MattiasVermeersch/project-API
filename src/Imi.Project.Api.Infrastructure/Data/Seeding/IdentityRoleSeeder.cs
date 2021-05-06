using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Imi.Project.Api.Infrastructure.Data.Seeding
{
    public class IdentityRoleSeeder
    {
        //Identity
        //Admin
        const string AdminRoleId = "00000000-0000-0000-000000000001";
        const string AdminRoleName = "Admin";

        //Warlord
        const string WarlordRoleId = "00000000-0000-0000-000000000002";
        const string WarlordRoleName = "Warlord";

        //RaidLeader
        const string RaidLeaderRoleId = "00000000-0000-0000-000000000003";
        const string RaidLeaderRoleName = "RaidLeader";

        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<IdentityRole>().HasData(
                new IdentityRole
                {
                    Id = AdminRoleId,
                    Name = AdminRoleName,
                    NormalizedName = AdminRoleName.ToUpper()
                },
                new IdentityRole
                {
                    Id = WarlordRoleId,
                    Name = WarlordRoleName,
                    NormalizedName = WarlordRoleName.ToUpper()
                },
                new IdentityRole
                {
                    Id = RaidLeaderRoleId,
                    Name = RaidLeaderRoleName,
                    NormalizedName = RaidLeaderRoleName.ToUpper()
                });
        }
    }
}
