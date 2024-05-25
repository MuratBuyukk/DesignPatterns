namespace DesignPattern.Facade.DAL
{
    public class OrderDetail
    {
        public int OrderDetailID { get; set; }
        public int? ProductID { get; set; }
        public Product Product { get; set; }
        public int? CustomerID { get; set; }
        public Customer Customer { get; set; }
        public int? OrderID { get; set; }
        public Order Order { get; set; }
        public int ProductCount { get; set; }
        public int ProductPrice { get; set; }
        public int ProductTotalPrice { get; set; }
    }
}
