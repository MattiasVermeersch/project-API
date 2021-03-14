using Imi.Project.Api.Core.Dtos.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Imi.Project.Api.Core.Dtos
{
    public class UserResponseDto : BaseDto
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public bool IsAdmin { get; set; }
        public bool IsRaidLeader { get; set; }
        public bool IsWarlord { get; set; }
        public ICollection<CharacterResponseDto> Characters { get; set; }
    }
}
