using ArtisansLocaux.Data;
using ArtisansLocaux.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ArtisansLocaux.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public required List<Artisan> Artisans { get; set; }

        public IndexModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public void OnGet()
        {
            Artisans = _context.Artisans.ToList();
        }
    }
}
