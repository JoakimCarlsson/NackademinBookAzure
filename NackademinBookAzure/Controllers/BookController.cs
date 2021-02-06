using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NackademinBookAzure.Data;
using NackademinBookAzure.Models;
using NackademinBookAzure.ViewModels;

namespace NackademinBookAzure.Controllers
{
    public class BookController : Controller
    {
        private readonly BookDbContext _dbContext;

        public BookController(BookDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            var model = new BookListIndexViewModel();

            foreach (Book book in _dbContext.Books)
            {
                model.Books.Add(new BookIndexViewModel
                {
                    Id = book.Id,
                    Title = book.Title,
                });
            }

            return View(model);
        }

        public IActionResult SelectedBook(int id)
        {
            var model = new SelectedBookIndexViewModel();
            var book = _dbContext.Books.First(r => r.Id == id);
            model.Title = book.Title;
            model.Description = book.Description;
            model.Author = book.Author;

            return View(model);
        }
    }
}
