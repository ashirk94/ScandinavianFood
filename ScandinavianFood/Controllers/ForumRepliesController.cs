using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ScandinavianFood.Models;
using ScandinavianFood.Models.DomainModels;
using System.Linq;
using System.Threading.Tasks;

namespace ScandinavianFood.Controllers
{
    public class ForumRepliesController : Controller
    {
        private readonly SiteDbContext _context;

        public ForumRepliesController(SiteDbContext context)
        {
            _context = context;
        }

        // GET: ForumReplies
        public async Task<IActionResult> Index()
        {
            ViewBag.Current = "ForumReplies";
            return View(await _context.ForumReply.ToListAsync());
        }

        // GET: ForumReplies/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var forumReply = await _context.ForumReply
                .FirstOrDefaultAsync(m => m.ReplyId == id);
            if (forumReply == null)
            {
                return NotFound();
            }

            return View(forumReply);
        }

        // GET: ForumReplies/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ForumReplies/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ReplyId,ForumPostId,ReplyText,ReplyDate")] ForumReply forumReply)
        {
            if (ModelState.IsValid)
            {
                _context.Add(forumReply);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(forumReply);
        }

        // GET: ForumReplies/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var forumReply = await _context.ForumReply.FindAsync(id);
            if (forumReply == null)
            {
                return NotFound();
            }
            return View(forumReply);
        }

        // POST: ForumReplies/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ReplyId,ForumPostId,ReplyText,ReplyDate")] ForumReply forumReply)
        {
            if (id != forumReply.ReplyId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(forumReply);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ForumReplyExists(forumReply.ReplyId))
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
            return View(forumReply);
        }

        // GET: ForumReplies/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var forumReply = await _context.ForumReply
                .FirstOrDefaultAsync(m => m.ReplyId == id);
            if (forumReply == null)
            {
                return NotFound();
            }

            return View(forumReply);
        }

        // POST: ForumReplies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var forumReply = await _context.ForumReply.FindAsync(id);
            _context.ForumReply.Remove(forumReply);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ForumReplyExists(int id)
        {
            return _context.ForumReply.Any(e => e.ReplyId == id);
        }
    }
}
