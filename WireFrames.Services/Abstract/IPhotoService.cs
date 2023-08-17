using System;
using System.Collections.Generic;
using System.Text;
using WireFrames.Entity.Concrete;

namespace WireFrames.Services.Abstract
{
    public interface IPhotoService
    {
        void Insert(Photo t);
        void Delete(Photo t);
        void Update(Photo t);
        List<Photo> GetAll();
        Photo GetById(int Id);
    }
}
