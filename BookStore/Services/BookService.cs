using BookStore.Data;
using BookStore.Models;
using BookStore.Services.IServices;

namespace BookStore.Services
{
    public class BookService : IBookService
    {
        private readonly ApplicationDbContext _db;
        public BookService(ApplicationDbContext db)
        {
            _db = db;
        }

        public void AddBook(Book book)
        {
            _db.Add(book);
            _db.SaveChanges();
        }

        public void DeleteBook(Book book)
        {
            _db.Remove(book);
            _db.SaveChanges();
        }

        public IEnumerable<Book> GetAllBooks()
        {
            return _db.Books.ToList();
        }

        public Book GetBook(int? id)
        {
            return _db.Books.FirstOrDefault(x => x.Id == id);
        }

        public void UpdateBook(Book book)
        {
            _db.Update(book);
            _db.SaveChanges();
        }
    }
}
