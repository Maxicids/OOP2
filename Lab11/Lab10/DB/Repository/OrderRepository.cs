using System.Collections.Generic;
using System.Data.Entity;
using Lab10.DB.Beans;

namespace Lab10.DB.Repository
{
    public class OrderRepository : IRepository<Order>
    {
        private DataContext dataContext;
 
        public OrderRepository(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }
 
        public IEnumerable<Order> GetAll()
        {
            return dataContext.Orders.Include(o=>o.Book);
        }
 
        public Order Get(int id)
        {
            return dataContext.Orders.Find(id);
        }
 
        public void Create(Order order)
        {
            dataContext.Orders.Add(order);
        }
 
        public void Update(Order order)
        {
            dataContext.Entry(order).State = EntityState.Modified;
        }
 
        public void Delete(int id)
        {
            var order = dataContext.Orders.Find(id);
            if (order != null)
                dataContext.Orders.Remove(order);
        }
    }
}