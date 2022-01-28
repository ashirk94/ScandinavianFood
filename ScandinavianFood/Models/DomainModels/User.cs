using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace ScandinavianFood.Models
{
    public class User : IdentityUser
    {
        [StringLength(30, MinimumLength = 3)]
        public string FirstName { get; set; }
    }
}
