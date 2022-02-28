using System;
using System.ComponentModel.DataAnnotations;

namespace ScandinavianFood.Models.DomainModels
{
    public class ForumReply
    {
        [Key]
        public int ReplyId { get; set; }
        public int ForumPostId { get; set; }

        [StringLength(100, MinimumLength = 3)]
        [Required]
        public string ReplyText { get; set; }
        public AppUser Replier { get; set; }
        public DateTime ReplyDate { get; set; } = DateTime.UtcNow;
    }
}
