using CleanArch.Application.Interfaces;
using CleanArch.Application.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CleanArch.MVC.Controllers
{
    public class ArtworkController : Controller
    {
        private IArtworkService _artworkService;

        public ArtworkController(IArtworkService artworkService)
        {
            _artworkService = artworkService;
        }
        [Authorize]
        public IActionResult Index()
        {
            ArtworkViewModel model = _artworkService.GetArtworks();

            return View(model);
        }
    }
}
