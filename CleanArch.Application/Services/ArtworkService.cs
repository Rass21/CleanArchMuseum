using CleanArch.Application.Interfaces;
using CleanArch.Application.ViewModels;
using CleanArch.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Application.Services
{
    public class ArtworkService : IArtworkService
    {
        public IArtworkRepository _repo;

        public ArtworkService(IArtworkRepository repo)
        {
            _repo = repo;
        }
        public ArtworkViewModel GetArtworks()
        {
            throw new NotImplementedException();
        }
    }
}
