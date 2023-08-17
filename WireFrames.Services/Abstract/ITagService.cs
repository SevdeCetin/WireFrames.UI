using System;
using System.Collections.Generic;
using System.Text;
using WireFrames.Entity.Concrete;

namespace WireFrames.Services.Abstract
{
    public interface ITagService
    {
        void Insert(Tag t);
        void Delete(Tag t);
        void Update(Tag t);
        List<Tag> GetAll();
        Tag GetById(int Id);
    }
}
