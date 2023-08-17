using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace WireFrames.Entity.Concrete
{
    public class Tag
    {
        [Key]
        public int TagID { get; set; }
        public string TagName { get; set; }
        public int PhotoID { get; set; }
        public Photo Photo { get; set; }
    }
}
