using System.ComponentModel.DataAnnotations;

namespace ScandinavianFood.Models
{
    public class UserModel
    {
        [StringLength(30, MinimumLength = 3)]
        [Required]
        public string Name { get; set; }
        public int Id { get; set; }
    }
}
