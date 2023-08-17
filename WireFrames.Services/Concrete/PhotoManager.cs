using System;
using System.Collections.Generic;
using System.Text;
using WireFrames.Data.Abstract;
using WireFrames.Data.EntityFramework;
using WireFrames.Entity.Concrete;
using WireFrames.Services.Abstract;

namespace WireFrames.Services.Concrete
{
    public class PhotoManager : IPhotoService
    {
        IPhotoDal _photoDal;

        public PhotoManager(IPhotoDal photoDal)
        {
            _photoDal = photoDal;
        }

        public void Delete(Photo photo)
        {
            _photoDal.Delete(photo);
        }

        public List<Photo> GetAll()
        {
            return _photoDal.GetAll();
        }

        public Photo GetById(int Id)
        {
            return _photoDal.GetById(Id);
        }

        public void Insert(Photo photo)
        {
            _photoDal.Insert(photo);
        }

        public void Update(Photo photo)
        {
            _photoDal.Update(photo);
        }
    }
}
