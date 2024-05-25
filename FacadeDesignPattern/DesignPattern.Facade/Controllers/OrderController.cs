using DesignPattern.Facade.DAL;
using DesignPattern.Facade.FacadePattern;
using Microsoft.AspNetCore.Mvc;

namespace DesignPattern.Facade.Controllers
{
    public class OrderController : Controller
    {
        private readonly Context _context;
        private readonly OrderFacade _orderFacade;
        public OrderController()
        {
            _context = new Context();
            _orderFacade = new OrderFacade();
        }

        [HttpGet]
        public IActionResult OrderDetailStart()
        {
            return View();
        }
        [HttpPost]
        public IActionResult OrderDetailStart(int customerId, int productId, int orderId, int productCount, int productPrice)
        {
            _orderFacade.ComplateOrderDetail(customerId,productId,orderId,productCount,productPrice);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult OrderStart()
        {
            return View();
        }
        [HttpPost]
        public IActionResult OrderStart(int customerId)
        {
            _orderFacade.ComplateOrder(customerId);
            return RedirectToAction("Index");
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
