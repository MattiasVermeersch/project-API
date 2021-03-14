using System;
using System.Collections.Generic;
using System.Text;

namespace Imi.Project.Api.Core.Dtos
{
    public class DungeonResponseDto
    {
        public string InstanceName { get; set; }
        public string Difficulty { get; set; }
        public DateTime Date { get; set; }
        public int? KeyIncrease { get; set; }
        public bool Succes { get; set; }
        public CharacterResponseDto Leader { get; set; }
        public Guid LeaderId { get; set; }
        public ICollection<CharacterResponseDto> Characters { get; set; }
    }
}
