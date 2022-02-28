using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ScandinavianFood.Models;
using ScandinavianFood.Models.DomainModels;
using System.Linq;
using System.Threading.Tasks;

namespace ScandinavianFood.Controllers
{
    public class ForumRatingsController : Controller
    {
        private readonly SiteDbContext _context;

        public ForumRatingsController(SiteDbContext context)
        {
            _context = context;
        }

        // GET: ForumRatings
        public async Task<IActionResult> Index()
        {
            return View(await _context.ForumRating.ToListAsync());
        }

        // GET: ForumRatings/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var forumRating = await _context.ForumRating
                .FirstOrDefaultAsync(m => m.RatingId == id);
            if (forumRating == null)
            {
                return NotFound();
            }

            return View(forumRating);
        }

        // GET: ForumRatings/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ForumRatings/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("RatingId,ForumPostId,Rating")] ForumRating forumRating)
        {
            if (ModelState.IsValid)
            {
                _context.Add(forumRating);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(forumRating);
        }

        // GET: ForumRatings/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var forumRating = await _context.ForumRating.FindAsync(id);
            if (forumRating == null)
            {
                return NotFound();
            }
            return View(forumRating);
        }

        // POST: ForumRatings/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("RatingId,ForumPostId,Rating")] ForumRating forumRating)
        {
            if (id != forumRating.RatingId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(forumRating);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ForumRatingExists(forumRating.RatingId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(forumRating);
        }

        // GET: ForumRatings/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var forumRating = await _context.ForumRating
                .FirstOrDefaultAsync(m => m.RatingId == id);
            if (forumRating == null)
            {
                return NotFound();
            }

            return View(forumRating);
        }

        // POST: ForumRatings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var forumRating = await _context.ForumRating.FindAsync(id);
            _context.ForumRating.Remove(forumRating);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ForumRatingExists(int id)
        {
            return _context.ForumRating.Any(e => e.RatingId == id);
        }
    }
}
