using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeekPlatform.ViewModels.Gallery
{
    public class GalleryAlbumViewModel : ViewModelBase
    {
        public int AlbumId { get; set; }
        public String AlbumName { get; set; }
        public String CreatorName { get; set; }
        public IEnumerable<String> Thumbnails { get; set; }
        public IEnumerable<String> Pictures { get; set; }
        public String JsTemplate { get; set; }
    }
}
