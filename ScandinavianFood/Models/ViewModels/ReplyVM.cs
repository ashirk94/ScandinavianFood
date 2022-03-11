using System.ComponentModel.DataAnnotations;

namespace ScandinavianFood.Models.ViewModels
{
    public class ReplyVM
    {
        public int ForumPostId { get; set; }

        [StringLength(100, MinimumLength = 3)]
        [Required]
        public string ReplyText { get; set; }
    }
}
