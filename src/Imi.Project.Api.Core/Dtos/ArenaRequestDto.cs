using Imi.Project.Api.Core.Dtos.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Imi.Project.Api.Core.Dtos
{
    public class ArenaRequestDto : BaseDto
    {
        public bool Iswon { get; set; }
        public DateTime Date { get; set; }
    }
}
