using System.Data.Entity;
using Lab10.DB.Beans;

namespace Lab10.DB
{
    public class DataContext : DbContext
    {
        public DataContext(): base("DBContext") { }
 
        public DbSet<Book> Books { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}