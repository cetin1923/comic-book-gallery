using Microsoft.AspNetCore.Mvc;
using comic_book_gallery.Models;
using comic_book_gallery.Data;
using System;

namespace ComicBookGallery.Controllers
{
    public class ComicBooksController : Controller
    {
        private ComicBookRepository _comicBookRepository = null;

        public ComicBooksController()
        {
            _comicBookRepository = new ComicBookRepository();
        }

        public ActionResult Detail(int? id)
        {
            if (id == null)
            {
               // return HttpNotFound();
            }
            var comicBook = _comicBookRepository.GetComicBook((int)id);
            
            return View(comicBook);
        }

        
    }
}

