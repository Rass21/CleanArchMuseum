using CleanArch.Domain.Interfaces;
using CleanArch.Domain.Models;
using CleanArch.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Infra.Data.Repositories
{
    public class ArtworkRepository : IArtworkRepository
    {
        private MuseumDbContext _context;
        public ArtworkRepository(MuseumDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Artwork> GetArtworks()
        {
            return _context.Artworks;
        }
    }
}
