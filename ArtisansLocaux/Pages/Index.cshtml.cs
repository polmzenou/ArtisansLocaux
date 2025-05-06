using Microsoft.AspNetCore.Mvc.RazorPages;
using ArtisansLocaux.Data;
using ArtisansLocaux.Models;

public class IndexModel : PageModel
{
    private readonly ApplicationDbContext _context;
    public List<Artisan> Artisans { get; set; } = new();

    public IndexModel(ApplicationDbContext context)
    {
        _context = context;
    }

    public void OnGet()
    {
        Artisans = _context.Artisans.ToList();
    }
}
