using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace WireFrames.Entity.Concrete
{
    public class Photo
    {
        [Key]
        public int PhotoID { get; set; }
        public string Title { get; set; }
        public List<Tag> Tag { get; set; }
        public string FilePath { get; set; }
    }
}
