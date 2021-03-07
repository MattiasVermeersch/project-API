using Imi.Project.Api.Core.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Imi.Project.Api.Core.Entities
{
    public class User : BaseEntity
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool IsAdmin { get; set; } = false;
        public bool IsRaidLeader { get; set; } = false;
        public bool IsWarlord { get; set; } = false;
        public ICollection<Character> Characters { get; set; }
    }
}
