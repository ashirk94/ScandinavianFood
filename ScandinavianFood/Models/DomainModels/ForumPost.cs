using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ScandinavianFood.Models.DomainModels
{
    public class ForumPost
    {
        private List<ForumReply> replies = new List<ForumReply>();
        private List<ForumRating> ratings = new List<ForumRating>();

        [StringLength(100, MinimumLength = 3)]
        [Required]
        public string Text { get; set; }
        public int ForumPostId { get; set; }
        public DateTime PostDate { get; set; } = DateTime.UtcNow;
        public AppUser Poster { get; set; }
        public List<ForumReply> ForumReplies
        {

            get
            {
                return replies;
            }
            set
            {
                replies = value;
            }
        }
        public List<ForumRating> ForumRatings
        {

            get
            {
                return ratings;
            }
            set
            {
                ratings = value;
            }
        }
    }
}
