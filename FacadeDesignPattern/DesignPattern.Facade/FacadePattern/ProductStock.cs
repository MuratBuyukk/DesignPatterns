using DesignPattern.Facade.DAL;

namespace DesignPattern.Facade.FacadePattern
{
    public class ProductStock
    {
        private readonly Context _context;

        public ProductStock()
        {
            _context = new Context();
        }

        public void StockDecrease(int id, int amount)
        {
            var value = _context.Products.Find(id);
            value.ProductStock -= amount;
            _context.SaveChanges();
        }
    }
}
