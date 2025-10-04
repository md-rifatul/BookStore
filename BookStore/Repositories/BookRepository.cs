using System.Linq.Expressions;
using BookStore.Data;
using BookStore.Models;
using BookStore.Repository.IRepository;

namespace BookStore.Repositories
{
    public class BookRepository : IBookRepository
    {
        private readonly ApplicationDbContext _db;

        public BookRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public void Add(Book book)
        {
            _db.Books.Add(book);
            _db.SaveChanges();
        }

        public Book? Get(Expression<Func<Book, bool>> filter)
        {
            IQueryable<Book> query = _db.Books;

            if (filter != null)
            {
                query = query.Where(filter);
            }

            return query.FirstOrDefault();
        }

        public List<Book> GetAll(Expression<Func<Book, bool>>? filter = null)
        {
            IQueryable<Book> query = _db.Books;

            if (filter != null)
            {
                query = query.Where(filter);
            }

            return query.ToList();
        }

        public void Remove(Book book)
        {
            _db.Books.Remove(book);
            _db.SaveChanges();
        }

        public void Update(Book book)
        {
            _db.Books.Update(book);
            _db.SaveChanges();
        }
    }
}
