using DesignPattern.Facade.DAL;

namespace DesignPattern.Facade.FacadePattern
{
    public class AddOrderDetail
    {
        private readonly Context _context;

        public AddOrderDetail()
        {
            _context = new Context();
        }

        public void AddNewOrderDetail(OrderDetail orderDetail) 
        {
            _context.OrderDetails.Add(orderDetail);
            _context.SaveChanges();
        }
    }
}
