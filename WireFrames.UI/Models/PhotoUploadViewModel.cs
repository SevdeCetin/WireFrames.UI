using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WireFrames.Entity.Concrete;

namespace WireFrames.UI.Models
{
    public class PhotoUploadViewModel
    {
        public string Title { get; set; }
        public string Tags { get; set; }
        public IFormFile Photo { get; set; } // IFormFile türünde Photo özelliği
    }

}
