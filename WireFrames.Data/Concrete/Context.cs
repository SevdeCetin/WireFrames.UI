using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using WireFrames.Entity.Concrete;

namespace WireFrames.Data.Concrete
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.;database=WireFrameDB; integrated security=true;");
        }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Photo> Photos { get; set; }
    }
}
