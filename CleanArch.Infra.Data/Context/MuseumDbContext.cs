using CleanArch.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Infra.Data.Context
{
    public class MuseumDbContext : DbContext
    {
        public MuseumDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Artwork> Artworks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Artwork>()
                .HasData(
                    new Artwork { Id = 1, Name = "Mona Lisa", Artist = "Leonardo Da Vinci", Year = "1503" },
                    new Artwork { Id = 2, Name = "Girl with a Pealr Earring", Artist = "Johannes Vermeer", Year = "1665"},
                    new Artwork { Id = 3, Name = "David", Artist = "Michelangelo", Year = "1501"},
                    new Artwork { Id = 4, Name = "Love is in the Bin", Artist = "Banksy", Year = "2006"},
                    new Artwork { Id = 5, Name = "The Starry Night", Artist = "Vincent van Gogh", Year = "1889" },
                    new Artwork { Id = 6, Name = "The Thinker", Artist = "Auguste Rodin", Year = "1880"}
                );
        }
    }
}
