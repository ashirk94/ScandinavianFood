using System;
using System.ComponentModel.DataAnnotations;

namespace ScandinavianFood.Models
{
    public class ForumPost
    {
        [StringLength(100, MinimumLength = 3)]
        [Required]
        public string Text { get; set; }
        public int Id { get; set; }
        public DateTime PostDate { get; set; } = DateTime.Now;
        public string Page { get; set; } = "Forum";
        [Range(1, 5)]
        public int Rating { get; set; }
        [StringLength(15, MinimumLength = 3)]
        [Required]
        public User User { get; set; }
    }
}
