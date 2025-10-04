using BookStore.Data;
using BookStore.Models;
using BookStore.Repository.IRepository;
using BookStore.Services.IServices;

namespace BookStore.Services
{
    public class BookService : IBookService
    {
        private readonly IBookRepository _bookRepository;
        public BookService(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public void AddBook(Book book)
        {
            _bookRepository.Add(book);
        }

        public void DeleteBook(Book book)
        {
            _bookRepository.Remove(book);
        }

        public IEnumerable<Book> GetAllBooks()
        {
            return _bookRepository.GetAll();
        }

        public Book GetBook(int? id)
        {
            return _bookRepository.Get(x => x.Id == id);
        }

        public void UpdateBook(Book book)
        {
            _bookRepository.Update(book);
        }
    }
}
