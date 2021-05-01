namespace Lab10.DB.Beans
{
    public class Order
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public int BookId { get; set; }
        public Book Book { get; set; }
    }
}