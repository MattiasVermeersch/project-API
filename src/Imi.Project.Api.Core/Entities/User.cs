using Imi.Project.Api.Core.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Imi.Project.Api.Core.Entities
{
    public class User : BaseEntity
    {
        public string Name { get; set; }
        public bool IsAdmin { get; set; }
        public bool IsRaidLeader { get; set; }
        public bool IsWarlord { get; set; }
        public ICollection<Character> Characters { get; set; }
    }
}
