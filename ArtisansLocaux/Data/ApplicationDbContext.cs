using Microsoft.EntityFrameworkCore;
using ArtisansLocaux.Models;

namespace ArtisansLocaux.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        public DbSet<Artisan> Artisans { get; set; }
    }
}
