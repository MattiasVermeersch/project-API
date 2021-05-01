﻿using Imi.Project.Api.Core.Entities.Base;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Imi.Project.Api.Core.Entities
{
    public class User : IdentityUser
    {
        public DateTime BirthDate { get; set; }
        public string Address { get; set; }
        public string FullName { get; set; }
        public string Password { get; set; }
        public ICollection<Character> Characters { get; set; }
    }
}
