using DesignPattern.ChainOfResponsibility.DAL;
using DesignPattern.ChainOfResponsibility.Models;

namespace DesignPattern.ChainOfResponsibility.ChainOfResponsibility
{
    public class Teller : Employee
    {
        private readonly Context _context;
        private readonly CustomerProcess _customerProcess;


        public Teller(Context context)
        {
            _context = context;
            _customerProcess = new CustomerProcess();
        }

        public override void ProcessRequest(CustomerProcessViewModel req)
        {
            _customerProcess.Amount = req.Amount.ToString();
            _customerProcess.Name = req.Name;
            _customerProcess.EmployeeName = "Teller - Cihan Çıtlak";
            if (req.Amount <= 100000)
            {
                _customerProcess.Description = "Withdrawal confirmed";
                _context.Add(_customerProcess);
                _context.SaveChanges();
            }
            else if (NextApprover != null)
            {
                _customerProcess.Description = "Since the Withdrawal Amount Exceeded the Teller's Daily Payment Limit, " +
                    "the Transaction was Referred to the Assistant Branch Manager";
                _context.Add(_customerProcess);
                _context.SaveChanges();
                NextApprover.ProcessRequest(req);
            }
        }
    }
}
