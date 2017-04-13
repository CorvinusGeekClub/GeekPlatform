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
                .Include(a => a.GalleryPicture)
                .Include(a => a.Creator);
            GalleryViewModel vm = new GalleryViewModel
            {
                Albums = albums.Select(a => new GalleryAlbumViewModel
                {
                    AlbumId = a.GalleryAlbumId,
                    AlbumName = a.Name,
                    CreatorName = a.Creator.Name
                })
            };
            return View(vm);
        }

        public String JsTemplateFor(GalleryAlbumViewModel vm)
        {
            var result = "var items = [";
            
            for (int i = 0; i < vm.Pictures.Count(); i++)
            {
                result += $"{{ src: '/gallery-uploads/{vm.Pictures.ElementAt(i)}', msrc: '/gallery-uploads/{vm.Thumbnails.ElementAt(i)}', w: 4032, h: 3024 }},";
            }

            result += " ];";
            return result;
        }
        public IActionResult Album(int? id)
        {
            GalleryAlbum album = DbContext.GalleryAlbum
                .Include(a => a.Creator)
                .Include(a => a.GalleryPicture)
                .FirstOrDefault(a=>a.GalleryAlbumId == id);
            if (album == null)
            {
                return NotFound();
            }
            GalleryAlbumViewModel vm = new GalleryAlbumViewModel
            {
                AlbumId = album.GalleryAlbumId,
                AlbumName = album.Name,
                CreatorName = album.Creator.Name,
                Thumbnails = album.GalleryPicture.Where(p => p.Album == album).Select(p => p.Filename),
                Pictures = album.GalleryPicture.Where(p => p.Album == album).Select(p => p.Filename),
            };
            vm.JsTemplate = JsTemplateFor(vm); // `this` could work too?
            return View(vm);
        }
    }
}