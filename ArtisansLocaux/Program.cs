using Microsoft.EntityFrameworkCore;
using ArtisansLocaux.Data;
using ArtisansLocaux.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddRazorPages();

var app = builder.Build();

app.UseStaticFiles();
app.MapRazorPages();

using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
    db.Database.Migrate(); // ✅ garantit que la BDD est à jour

    if (!db.Artisans.Any())
    {
        db.Artisans.AddRange(
            new Artisan { Name = "Ébéniste Pierre", Bio = "Travail du bois sur mesure", Category = "Bois", ImageUrl = "/images/ebeniste.jpg" },
            new Artisan { Name = "Céramiste Claire", Bio = "Vaisselle artisanale", Category = "Céramique", ImageUrl = "/images/ceramiste.jpg" }
        );
        db.SaveChanges();
        Console.WriteLine("✅ Seed terminé, base prête.");
    }
}


app.Run();
