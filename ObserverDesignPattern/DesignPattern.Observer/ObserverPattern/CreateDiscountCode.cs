using DesignPattern.Observer.DAL;
using System;

namespace DesignPattern.Observer.ObserverPattern
{
    public class CreateDiscountCode : IObserver
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly Context _context = new Context();

        public CreateDiscountCode(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }
        public void CreateNewUser(AppUser appUser)
        {
            _context.Discounts.Add(new Discount
            {
                DiscountCode = "JRNLMAY",
                DiscountAmount = 35,
                DiscountCodeStatus = true
            });
            _context.SaveChanges();
        }
    }
}
