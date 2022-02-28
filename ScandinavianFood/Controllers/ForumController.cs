using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ScandinavianFood.Models.DomainModels;
using ScandinavianFood.Models.Repositories;
using ScandinavianFood.Models.ViewModels;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScandinavianFood.Controllers
{
    public class ForumController : Controller
    {
        private readonly UserManager<AppUser> UserManager;
        private IPostRepository PostData { get; set; }

        //initialize with repo and user manager
        public ForumController(UserManager<AppUser> userMngr, IPostRepository postRep)
        {
            PostData = postRep;
            UserManager = userMngr;
        }

        //forum
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            ViewBag.Current = "Forum";
            //query posts by date
            List<ForumPost> posts = new List<ForumPost>();
            await Task.Run(() =>
               posts = PostData.ForumPosts
                             .OrderBy(p => p.PostDate)
                             .ToList<ForumPost>()
            );
            // pass to vm
            var forumVM = new ForumVM
            {
                Posts = posts,
                PostText = ""
            };
            return View(forumVM);
        }
        //require login
        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Index(ForumVM forumVM)
        {
            // use vm data
            var post = new ForumPost 
            { 
                Text = forumVM.PostText
            };

            //current user for post
            post.Poster = await UserManager.GetUserAsync(User);

            //if valid post
            if (ModelState.IsValid)
            {
                if (post.ForumPostId == 0)
                {
                    await PostData.Insert(post);
                }
                else
                {
                    await PostData.Update(post);
                }
                await PostData.Save();
                ModelState.Clear();
            }
            return RedirectToAction("Index", "Forum");
        }
        // reply page
        [Authorize]
        public async Task<IActionResult> AddReply(int id)
        {
            var replyVM = new ReplyVM
            {
                ForumPostId = id,
                ReplyText = ""
            };
            var post = await PostData.GetById(replyVM.ForumPostId);
            ViewBag.Post = post.Text;

            return View(replyVM);
        }
        [Authorize]
        [HttpPost]
        public async Task<IActionResult> AddReply(ReplyVM replyVM)
        {
            // reply with data from vm
            var reply = new ForumReply
            {
                ReplyText = replyVM.ReplyText,
                ForumPostId = replyVM.ForumPostId
            };
            reply.Replier = await UserManager.GetUserAsync(User);

            var post = await PostData.GetById(replyVM.ForumPostId);


            // store with post if valid
            if (ModelState.IsValid && post != null)
            {
                post.ForumReplies.Add(reply);
                await PostData.Update(post);
                ModelState.Clear();
                return RedirectToAction("Index", "Forum");
            }

            return View(replyVM);
        }
        // rating page
        [Authorize]
        public async Task<IActionResult> AddRating(int id)
        {
            var ratingVM = new RatingVM
            {
                ForumPostId = id,
                Rating = 5
            };
            var post = await PostData.GetById(ratingVM.ForumPostId);
            ViewBag.Post = post.Text;

            return View(ratingVM);
        }
        [Authorize]
        [HttpPost]
        public async Task<IActionResult> AddRating(RatingVM ratingVM)
        {
            // rating with data from vm
            var rating = new ForumRating
            {
                ForumPostId = ratingVM.ForumPostId,
                Rating = ratingVM.Rating
            };
            rating.Rater = await UserManager.GetUserAsync(User);

            var post = await PostData.GetById(ratingVM.ForumPostId);


            // store with post if valid
            if (ModelState.IsValid && post != null)
            {
                post.ForumRatings.Add(rating);
                await PostData.Update(post);
                ModelState.Clear();
                return RedirectToAction("Index", "Forum");
            }

            return View(ratingVM);
        }
    }
}
