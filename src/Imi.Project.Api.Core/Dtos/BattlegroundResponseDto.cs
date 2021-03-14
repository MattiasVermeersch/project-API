using System;
using System.Collections.Generic;
using System.Text;

namespace Imi.Project.Api.Core.Dtos
{
    public class BattlegroundResponseDto
    {
        public string InstanceName { get; set; }
        public int Mode { get; set; }
        public bool IsWon { get; set; }
        public DateTime Date { get; set; }
        public CharacterResponseDto Leader { get; set; }
        public Guid LeaderId { get; set; }
        public ICollection<CharacterResponseDto> Characters { get; set; }
    }
}
