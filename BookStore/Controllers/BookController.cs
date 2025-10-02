using BookStore.Models;
using BookStore.Services.IServices;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Controllers
{
    public class BookController : Controller
    {
        private readonly IBookService _bookService;
        public BookController(IBookService bookService)
        {
            _bookService = bookService;
        }
        public IActionResult Index()
        {
            try
            {
                var books = _bookService.GetAllBooks();
                return View(books);
            }
            catch(Exception e)
            {
                ViewBag.ErrorMessage = "An error occurred while loading books. Please try again later.";
                return View(new List<Book>());
            }

        }
        public IActionResult Details(int bookId)
        {
            try
            {
                var book = _bookService.GetBook(bookId);
                if(book == null)
                {
                    ViewBag.ErrorMessage = "The requested book was not found.";
                    return View();
                }
                return View(book);
            }
            catch(Exception e)
            {
                ViewBag.ErrorMessage = "An error occurred while retrieving book details.";
                return View();
            }

        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Book book)
        {
            try
            {
                if(ModelState.IsValid)
                {
                    _bookService.AddBook(book);
                    return RedirectToAction("Index");
                }
                return View(book);
            }
            catch(DbUpdateException e)
            {
                ViewBag.ErrorMessage = "Failed to add the book due to a database error.";
                return View(book);
            }
            catch (Exception e)
            {
                ViewBag.ErrorMessage = "An unexpected error occurred while adding the book.";
                return View(book);
            }

        }
        public IActionResult Edit(int bookId)
        {
            try
            {
                var book = _bookService.GetBook(bookId);
                if (book == null)
                {
                    ViewBag.ErrorMessage = "The requested book was not found.";
                    return View();
                }
                return View(book);
            }
            catch(Exception e)
            {
                ViewBag.ErrorMessage = "An error occurred while loading the book for editing.";
                return View();
            }

        }
        [HttpPost]
        public IActionResult Edit(Book book)
        {
            try
            {
                if(ModelState.IsValid)
                {
                    _bookService.UpdateBook(book);
                    return RedirectToAction("Index");
                }
                return View(book);
            }
            catch(DbUpdateException e)
            {
                ViewBag.ErrorMessage = "Failed to update the book due to a database error.";
                return View(book);
            }    
            catch(Exception e)
            {
                ViewBag.ErrorMessage = "An unexpected error occurred while updating the book.";
                return View(book);
            }

        }
        public IActionResult Delete(int bookId)
        {
            try
            {
                var book = _bookService.GetBook(bookId);
                if(book==null)
                {
                    ViewBag.ErrorMessage = "The requested book was not found.";
                    return View();
                }
                return View(book);
            }
            catch(Exception e)
            {
                ViewBag.ErrorMessage = "An error occurred while loading the book for deletion.";
                return View();
            }

        }

        [HttpPost,ActionName("Delete")]
        public IActionResult DeleteConfirmed(Book book)
        {
            try
            {
                _bookService.DeleteBook(book);
                return RedirectToAction("Index");
            }
            catch (DbUpdateException e)
            {
                ViewBag.ErrorMessage = "Failed to delete the book due to a database error.";
                return View(book);
            }
            catch (Exception e)
            {
                ViewBag.ErrorMessage = "An unexpected error occurred while deleting the book.";
                return View(book);
            }

        }
    }
}
