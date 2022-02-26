using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using ScandinavianFood.Models.DomainModels;

namespace ScandinavianFood.Models.ViewModels
{
    public class AdminVM
    {
        public IEnumerable<AppUser> Users { get; set; }
        public IEnumerable<IdentityRole> Roles { get; set; }
    }
}
