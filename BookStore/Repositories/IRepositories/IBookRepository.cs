using BookStore.Models;
using System.Linq.Expressions;

namespace BookStore.Repository.IRepository
{
    public interface IBookRepository
    {
        void Add(Book book);
        void Remove(Book book);

        void Update(Book book);

        Book? Get(Expression<Func<Book, bool>> filter);

        List<Book> GetAll(Expression<Func<Book, bool>>? filter = null);
    }
}
