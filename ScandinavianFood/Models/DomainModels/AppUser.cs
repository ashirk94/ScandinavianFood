using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ScandinavianFood.Models
{
    public class AppUser : IdentityUser
    {
        [NotMapped]
        public IList<string> RoleNames { get; set; }
    }
}
