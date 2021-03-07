using System;
using System.Collections.Generic;
using System.Text;

namespace Imi.Project.Api.Core.Entities.Base
{
    public abstract class PvpInstance : BaseEntity
    {
        public bool IsWon { get; set; }
        public DateTime Date { get; set; }
        public Guid LeaderId { get; set; }
        public Character Leader { get; set; }
        public ICollection<Character> CharactersParticipated { get; set; }
    }
}
