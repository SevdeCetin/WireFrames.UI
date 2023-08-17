using System;
using System.Collections.Generic;
using System.Text;
using WireFrames.Data.Abstract;
using WireFrames.Entity.Concrete;
using WireFrames.Services.Abstract;

namespace WireFrames.Services.Concrete
{
    public class TagManager : ITagService
    {
        ITagDal _tagDal;

        public TagManager(ITagDal tagDal)
        {
            _tagDal = tagDal;
        }

        public void Delete(Tag t)
        {
            _tagDal.Delete(t);
        }

        public List<Tag> GetAll()
        {
            return _tagDal.GetAll();
        }

        public Tag GetById(int Id)
        {
            return _tagDal.GetById(Id);
        }

        public void Insert(Tag t)
        {
            _tagDal.Insert(t);
        }

        public void Update(Tag t)
        {
            _tagDal.Update(t);
        }
    }
}
