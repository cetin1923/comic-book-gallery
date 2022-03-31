using Microsoft.AspNetCore.Mvc;
using comic_book_gallery.Models;
using comic_book_gallery.Data;
using System;

namespace ComicBookGallery.Controllers
{
    public class ComicBooksController : Controller
    {
        private ComicBookRepository _comicBooksRepository = null;

        public ComicBooksController()
        {
            _comicBooksRepository = new ComicBookRepository();
        }

        public ActionResult Index()
        {
            var comicBooks = _comicBooksRepository.GetComicBooks();

            return View(comicBooks);
            
        }

        public ActionResult Detail(int? id)
        {
            if (id == null)
            {
               // return HttpNotFound();
            }
            var comicBook = _comicBooksRepository.GetComicBook((int)id);
            
            return View(comicBook);
        }

        
    }
}

