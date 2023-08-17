using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using WireFrames.Data.EntityFramework;
using WireFrames.Entity.Concrete;
using WireFrames.Services.Concrete;
using WireFrames.UI.Models;

namespace WireFrames.UI.Controllers
{
    public class PhotoController : Controller
    {
        PhotoManager pm = new PhotoManager(new EfPhotoRepo());
        TagManager tm = new TagManager(new EfTagRepo());
        public IActionResult Index()
        {
            var values = pm.GetAll();
            return View(values);
        }
        [HttpGet]
        public IActionResult Upload()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Upload(PhotoUploadViewModel model)
        {
            if (ModelState.IsValid)
            {
                if (model.Photo != null && model.Photo.Length > 0)
                {
                    
                    var fileName = Path.GetFileName(model.Photo.FileName);

                   
                    var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "uploads", fileName);

                    
                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        model.Photo.CopyTo(stream);
                    }

                   
                    var photo = new Photo
                    {
                        Title = model.Title,
                        FilePath = Path.Combine("uploads", fileName) // Örneğin dosya yolunu "uploads/foto.jpg" olarak kaydedebilirsiniz
                    };
                    List<Tag> tags = new List<Tag>();
                    foreach (var tagName in model.Tags.Split(',')) // Virgülle ayrılmış etiketleri böler
                    {
                        var tag = new Tag { TagName = tagName.Trim() };
                        tags.Add(tag);                       
                    }
                    
                    photo.Tag = tags;
                    pm.Insert(photo);

                    return RedirectToAction("Index");
                }
            }

            return View(model);
        }

        public IActionResult Details(int id)
        {
            var photo = pm.GetById(id);

            if (photo == null)
            {
                return NotFound();
            }

            var viewModel = new PhotoDetailViewModel();
            viewModel.Photo = photo;
            var tags = tm.GetAll().Where(x => x.PhotoID == photo.PhotoID).ToList();
            
            string tagJoin = string.Join(", ", tags.Select(t => t.TagName));
            viewModel.Tags = tagJoin;

            return View(viewModel);
        }
        [HttpPost]
        public IActionResult Delete(int id)
        {
            var photo = pm.GetById(id);

            if (photo == null)
            {
                return NotFound();
            }

            pm.Delete(photo);

            return RedirectToAction("Index");
        }



    }
}
