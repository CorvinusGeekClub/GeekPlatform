using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeekPlatform.ViewModels.Gallery
{
    public class GalleryViewModel : ViewModelBase
    {
        public IEnumerable<GalleryAlbumViewModel> Albums { get; set; }
    }
}
