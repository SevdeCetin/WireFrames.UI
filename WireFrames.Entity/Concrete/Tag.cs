using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace WireFrames.Entity.Concrete
{
    public class Tag
    {
        [Key]
        public int ID { get; set; }
        public string TagName { get; set; }
    }
}
