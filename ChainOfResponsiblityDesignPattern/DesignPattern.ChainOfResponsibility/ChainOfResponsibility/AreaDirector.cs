using DesignPattern.ChainOfResponsibility.DAL;
using DesignPattern.ChainOfResponsibility.Models;

namespace DesignPattern.ChainOfResponsibility.ChainOfResponsibility
{
    public class AreaDirector : Employee
    {
        private readonly Context _context;
        private readonly CustomerProcess _customerProcess;

        public AreaDirector(Context context)
        {
            _context = context;
            _customerProcess = new CustomerProcess();
        }

        public override void ProcessRequest(CustomerProcessViewModel req)
        {
            _customerProcess.Amount = req.Amount.ToString();
            _customerProcess.Name = req.Name;
            _customerProcess.EmployeeName = "Area Director - Murat Büyük";
            if (req.Amount <= 400000)
            {
                _customerProcess.Description = "Withdrawal confirmed";
            }
            else
            {
                _customerProcess.Description = "Since the Withdrawal Amount Exceeded the Area Director's " +
                    "Daily Payment Limit, the Transaction was Rejected. Customer can withdraw maximum " +
                    "$400,000 in one day";
            }
            _context.Add(_customerProcess);
            _context.SaveChanges();
        }
    }
}
