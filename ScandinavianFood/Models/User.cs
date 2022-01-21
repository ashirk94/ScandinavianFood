using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace ScandinavianFood.Models
{
    public class User : IdentityUser
    {
        [StringLength(30, MinimumLength = 3)]
        [Required]
        public string Username { get; set; }
    }
}
