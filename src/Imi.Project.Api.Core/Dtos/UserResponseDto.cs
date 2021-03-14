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
        //property to list roles
        public ICollection<string> Roles { get; set; }
        public ICollection<CharacterResponseDto> Characters { get; set; }
    }
}
