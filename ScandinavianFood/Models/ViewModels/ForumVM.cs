using ScandinavianFood.Models.DomainModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ScandinavianFood.Models.ViewModels
{
    public class ForumVM
    {
        public List<ForumPost> Posts { get; set; }

        [StringLength(100, MinimumLength = 3)]
        [Required]
        public string PostText { get; set; }
    }
}
