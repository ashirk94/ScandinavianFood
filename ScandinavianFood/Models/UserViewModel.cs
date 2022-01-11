using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ScandinavianFood.Models
{
    public class UserViewModel : UserModel
    {
        [Required]
        public UserModel User { get; set; }
        [Required]
        public IEnumerable<UserModel> Users { get; set; }
    }
}
