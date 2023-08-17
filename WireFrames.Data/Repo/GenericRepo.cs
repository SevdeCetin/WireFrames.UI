using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WireFrames.Data.Abstract;
using WireFrames.Data.Concrete;

namespace WireFrames.Data.Repo
{
    public class GenericRepo<T> : IGenericDal<T> where T : class
    {
        public void Delete(T t)
        {
            using var c = new Context();
            c.Remove(t);
            c.SaveChanges();
        }

        public List<T> GetAll(T t)
        {
            using var c = new Context();
            return c.Set<T>().ToList();
            
        }

        public T GetById(int Id)
        {
            using var c = new Context();
            return c.Set<T>().Find(Id);
        }

        public void Insert(T t)
        {
            using var c = new Context();
            c.Add(t);
            c.SaveChanges();
           
        }

        public void Update(T t)
        {
            using var c = new Context();
            c.Update(t);
            c.SaveChanges();
            
        }
    }
}
