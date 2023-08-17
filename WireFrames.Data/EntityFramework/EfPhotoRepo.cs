using System;
using System.Collections.Generic;
using System.Text;
using WireFrames.Data.Abstract;
using WireFrames.Data.Repo;
using WireFrames.Entity.Concrete;

namespace WireFrames.Data.EntityFramework
{
    public class EfPhotoRepo:GenericRepo<Photo>, IPhotoDal
    {
    }
}
