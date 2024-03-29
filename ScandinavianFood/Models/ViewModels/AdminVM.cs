﻿using Microsoft.AspNetCore.Identity;
using ScandinavianFood.Models.DomainModels;
using System.Collections.Generic;

namespace ScandinavianFood.Models.ViewModels
{
    public class AdminVM
    {
        public IEnumerable<AppUser> Users { get; set; }
        public IEnumerable<IdentityRole> Roles { get; set; }
    }
}
