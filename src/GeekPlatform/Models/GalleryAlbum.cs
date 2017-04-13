using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeekPlatform.Models
{
    public class GalleryAlbum
    {
        public int GalleryAlbumId { get; set; }
        public String Name { get; set; }
        public virtual Profile Creator { get; set; }
        public DateTime CreatedAt { get; set; }
        public virtual ICollection<GalleryPicture> GalleryPicture { get; set; }

        public GalleryAlbum()
        {
            GalleryPicture = new HashSet<GalleryPicture>();
        }
    }
}
