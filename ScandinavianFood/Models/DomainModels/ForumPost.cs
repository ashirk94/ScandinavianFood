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
        public string User { get; set; } = "Anonymous";
    }
}
