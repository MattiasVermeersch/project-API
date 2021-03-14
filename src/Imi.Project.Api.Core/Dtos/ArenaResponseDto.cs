using Imi.Project.Api.Core.Dtos.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Imi.Project.Api.Core.Dtos
{
    public class ArenaResponseDto : BaseDto
    {
        //Arena has two modes: 2 players or 3 players
        public int Mode { get; set; }
        public bool Iswon { get; set; }
        public DateTime Date { get; set; }
        public CharacterResponseDto Leader { get; set; }
        public Guid LeaderId { get; set; }
        public ICollection<CharacterResponseDto> Characters { get; set; }
    }
}
