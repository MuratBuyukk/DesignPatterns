using DesignPattern.Facade.DAL;

namespace DesignPattern.Facade.FacadePattern
{
    public class OrderFacade
    {
        Order order = new Order();
        OrderDetail orderDetail = new OrderDetail();
        ProductStock productStock = new ProductStock();
        AddOrder addOrder = new AddOrder();
        AddOrderDetail addOrderDetail = new AddOrderDetail();

        public void ComplateOrderDetail(int customerId, int productId, int orderId, int productCount, int productPrice)
        {

            orderDetail.OrderID = orderId;
            orderDetail.CustomerID = customerId;
            orderDetail.ProductID = productId;
            orderDetail.ProductCount = productCount;
            orderDetail.ProductPrice = productPrice;
            orderDetail.ProductTotalPrice = productPrice*productCount;
            addOrderDetail.AddNewOrderDetail(orderDetail);

            productStock.StockDecrease(productId, productCount);
        }

        public void ComplateOrder(int customerId)
        {
            order.CustomerID = customerId;
            addOrder.AddNewOrder(order);
        }
    }
}
