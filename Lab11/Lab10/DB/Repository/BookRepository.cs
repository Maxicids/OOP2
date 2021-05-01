using System.Collections.Generic;
using System.Data.Entity;
using Lab10.DB.Beans;

namespace Lab10.DB.Repository
{
    public class BookRepository : IRepository<Book>
    {
        private readonly DataContext dataContext;
 
        public BookRepository(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }
 
        public IEnumerable<Book> GetAll()
        {
            return dataContext.Books;
        }
 
        public Book Get(int id)
        {
            return dataContext.Books.Find(id);
        }
 
        public void Create(Book book)
        {
            dataContext.Books.Add(book);
        }
 
        public void Update(Book book)
        {
            dataContext.Entry(book).State = EntityState.Modified;
        }
 
        public void Delete(int id)
        {
            var book = dataContext.Books.Find(id);
            if (book != null)
                dataContext.Books.Remove(book);
        }
    }
}