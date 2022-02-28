using System.ComponentModel.DataAnnotations;

namespace ScandinavianFood.Models.DomainModels
{
    public class ForumRating
    {
        [Key]
        public int RatingId { get; set; }
        public int ForumPostId { get; set; }
        public int Rating { get; set; }
        public AppUser Rater { get; set; }
    }
}
