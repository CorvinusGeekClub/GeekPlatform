using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeekPlatform.ViewModels.Gallery
{
    public class GalleryAlbumViewModel : ViewModelBase
    {
        public String AlbumName { get; set; }
        public String CreatorName { get; set; }
        public String Location { get; set; }
    }
}
