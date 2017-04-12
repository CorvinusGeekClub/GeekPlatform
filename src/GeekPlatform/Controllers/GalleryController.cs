using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GeekPlatform.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using GeekPlatform.ViewModels.Gallery;

namespace GeekPlatform.Controllers
{
    public class GalleryController : ControllerBase
    {
        public GalleryController(UserManager<Profile> userManager, GeekDatabaseContext dbContext) : base(userManager, dbContext)
        {
        }

        public IActionResult Index()
        {
            IEnumerable<GalleryAlbum> albums = DbContext.GalleryAlbum
                .Include(a => a.Creator);
            GalleryViewModel vm = new GalleryViewModel
            {
                Albums = albums.Select(a => new GalleryAlbumViewModel
                {
                    AlbumName = a.Name,
                    CreatorName = a.Creator.Name,
                    Location = a.GalleryAlbumId.ToString()
                })
            };
            return View(vm);
        }
    }
}