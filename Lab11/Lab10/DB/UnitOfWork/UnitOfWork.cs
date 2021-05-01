using System;
using Lab10.DB.Repository;

namespace Lab10.DB.UnitOfWork
{
    public class UnitOfWork : IDisposable
    {
        private readonly DataContext dataContext = new DataContext();
        private BookRepository bookRepository;
        private OrderRepository orderRepository;
 
        public BookRepository Books => bookRepository ?? (bookRepository = new BookRepository(dataContext));

        public OrderRepository Orders => orderRepository ?? (orderRepository = new OrderRepository(dataContext));

        public void Save()
        {
            dataContext.SaveChanges();
        }
 
        private bool disposed = false;
 
        public virtual void Dispose(bool disposing)
        {
            if (disposed) return;
            if (disposing)
            {
                dataContext.Dispose();
            }
            disposed = true;
        }
 
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}