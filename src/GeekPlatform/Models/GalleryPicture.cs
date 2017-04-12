using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace GeekPlatform.Models
{
    public partial class GalleryPicture
    {
        public int GalleryPictureId { get; set; }
        public String Filename { get; set; }
        public String Caption { get; set; }
        public DateTime UploadedAt { get; set; }
        public virtual Profile Uploader { get; set; }
        public virtual GalleryAlbum Album { get; set; }
    }
}
