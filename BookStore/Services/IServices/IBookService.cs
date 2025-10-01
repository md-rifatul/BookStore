using BookStore.Models;

namespace BookStore.Services.IServices
{
    public interface IBookService
    {
        IEnumerable<Book> GetAllBooks();
        Book GetBook(int? id);
        void AddBook(Book book);
        void UpdateBook(Book book);
        void DeleteBook(Book book);
    }
}
