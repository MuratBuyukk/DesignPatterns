using DesignPattern.ChainOfResponsibility.DAL;
using DesignPattern.ChainOfResponsibility.Models;

namespace DesignPattern.ChainOfResponsibility.ChainOfResponsibility
{
    public class AssistantBranchManager : Employee
    {
        private readonly Context _context;
        private readonly CustomerProcess _customerProcess;

        public AssistantBranchManager(Context context)
        {
            _context = context;
            _customerProcess = new CustomerProcess();
        }

        public override void ProcessRequest(CustomerProcessViewModel req)
        {
            _customerProcess.Amount = req.Amount.ToString();
            _customerProcess.Name = req.Name;
            _customerProcess.EmployeeName = "Assistant Branch Manager - Oğuz Keskiner";
            if (req.Amount <= 150000)
            {
                _customerProcess.Description = "Withdrawal confirmed";
                _context.Add(_customerProcess);
                _context.SaveChanges();
            }
            else if (NextApprover != null)
            {
                _customerProcess.Description = "Since the Withdrawal Amount Exceeded the Assistant Branch Manager's " +
                    "Daily Payment Limit, the Transaction was Referred to the Branch Manager";
                _context.Add(_customerProcess);
                _context.SaveChanges();
                NextApprover.ProcessRequest(req);
            }

        }
    }
}
