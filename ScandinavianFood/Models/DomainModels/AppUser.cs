using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ScandinavianFood.Models.DomainModels
{
    public class AppUser : IdentityUser
    {
        [NotMapped]
        public ICollection<string> RoleNames { get; set; }
    }
}
