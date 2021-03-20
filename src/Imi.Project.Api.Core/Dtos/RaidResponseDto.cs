using Imi.Project.Api.Core.Dtos.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Imi.Project.Api.Core.Dtos
{
    public class RaidResponseDto: BaseDto
    {
        public string InstanceName { get; set; }
        public string Difficulty { get; set; }
        public DateTime Date { get; set; }
        public double Progress { get; set; }
        public CharacterResponseDto Leader { get; set; }
        public Guid LeaderId { get; set; }
        public ICollection<CharacterResponseDto> Characters { get; set; }
    }
}
