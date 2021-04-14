using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EAD2CA2;
using EAD2CA2.Models;

namespace EAD2CA2.Controllers
{
    public class VideoGameListingsController : Controller
    {
        private readonly VideoGameContext _context;

        public VideoGameListingsController(VideoGameContext context)
        {
            _context = context;
        }

        // GET api/all
        [HttpGet("OrderByTitle")]
        public IEnumerable<VideoGameListing> GetAllListingsByTitle()
        {
            return _context.VideoGameListing.OrderBy(s => s.Title);
        }

        // GET api/{title}
        [HttpGet("SearchByTitle/{title}")]
        public IEnumerable<VideoGameListing> SearchForTitle(string title)
        {
            return _context.VideoGameListing.Where(s => s.Title == title);
        }

        // GET api/all
        [HttpGet("OrderByDate")]
        public IEnumerable<VideoGameListing> GetAllListingsByDate()
        {
            return _context.VideoGameListing.OrderBy(s => s.ReleaseDate);
        }

        // GET api/all
        [HttpGet("FilterByRating/{rating}")]
        public IEnumerable<VideoGameListing> FilterListingsByRating(int rating)
        {
            return _context.VideoGameListing.Where(s => s.AgeRating == rating);
        }

        // GET api/
        [HttpGet("FilterByDateRange/{date1}/{date2}")]
        public IEnumerable<VideoGameListing> FilterListingsByDateRange(DateTime date1, DateTime date2)
        {
            return _context.VideoGameListing.Where(s => s.ReleaseDate > date1 && s.ReleaseDate < date2);
        }

        // GET: VideoGameListings
        public async Task<IActionResult> Index()
        {
            return View(await _context.VideoGameListing.ToListAsync());
        }

        // GET: VideoGameListings/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var videoGameListing = await _context.VideoGameListing
                .FirstOrDefaultAsync(m => m.ID == id);
            if (videoGameListing == null)
            {
                return NotFound();
            }

            return View(videoGameListing);
        }

        // GET: VideoGameListings/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: VideoGameListings/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Title,AgeRating,ReleaseDate")] VideoGameListing videoGameListing)
        {
            if (ModelState.IsValid)
            {
                _context.Add(videoGameListing);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(videoGameListing);
        }

        // GET: VideoGameListings/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var videoGameListing = await _context.VideoGameListing.FindAsync(id);
            if (videoGameListing == null)
            {
                return NotFound();
            }
            return View(videoGameListing);
        }

        // POST: VideoGameListings/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Title,AgeRating,ReleaseDate")] VideoGameListing videoGameListing)
        {
            if (id != videoGameListing.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(videoGameListing);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VideoGameListingExists(videoGameListing.ID))
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
            return View(videoGameListing);
        }

        // GET: VideoGameListings/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var videoGameListing = await _context.VideoGameListing
                .FirstOrDefaultAsync(m => m.ID == id);
            if (videoGameListing == null)
            {
                return NotFound();
            }

            return View(videoGameListing);
        }

        // POST: VideoGameListings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var videoGameListing = await _context.VideoGameListing.FindAsync(id);
            _context.VideoGameListing.Remove(videoGameListing);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VideoGameListingExists(int id)
        {
            return _context.VideoGameListing.Any(e => e.ID == id);
        }
    }
}
