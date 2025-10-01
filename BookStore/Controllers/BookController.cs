using BookStore.Models;
using BookStore.Services.IServices;
using Microsoft.AspNetCore.Mvc;

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
            var books = _bookService.GetAllBooks();
            return View(books);
        }
        public IActionResult Details(int bookId)
        {
            var book = _bookService.GetBook(bookId);
            return View(book);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Book book)
        {
            _bookService.AddBook(book);
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int bookId)
        {
            var book = _bookService.GetBook(bookId);
            return View(book);
        }
        [HttpPost]
        public IActionResult Edit(Book book)
        {
            _bookService.UpdateBook(book);
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int bookId)
        {
             var book = _bookService.GetBook(bookId);
            return View(book);
        }
        [HttpPost]
        public IActionResult Delete(Book book)
        {
            _bookService.DeleteBook(book);
            return RedirectToAction("Index");
        }
    }
}
