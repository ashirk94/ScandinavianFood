using System.ComponentModel.DataAnnotations;

namespace ScandinavianFood.Models.ViewModels
{
    public class RatingVM
    {
        public int ForumPostId { get; set; }

        [Range(1, 10, ErrorMessage = "Rating must be between 1 and 10")]
        public int Rating { get; set; }
    }
}
