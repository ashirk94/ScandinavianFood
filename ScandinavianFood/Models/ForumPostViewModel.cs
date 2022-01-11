using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScandinavianFood.Models
{
    public class ForumPostViewModel : ForumPostModel
    {
        public ForumPostModel Post { get; set; }
        public IEnumerable<ForumPostModel> Posts { get; set; }
    }
}
