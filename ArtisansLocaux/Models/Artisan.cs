namespace ArtisansLocaux.Models
{
    public class Artisan
    {
        public required int Id { get; set; }
        public required string Name { get; set; }
        public required string Bio { get; set; }
        public required string Category { get; set; }
        public required string ImageUrl { get; set; }
    }
}
