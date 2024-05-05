using DesignPattern.ChainOfResponsibility.ChainOfResponsibility;
using DesignPattern.ChainOfResponsibility.DAL;
using DesignPattern.ChainOfResponsibility.Models;
using Microsoft.AspNetCore.Mvc;

namespace DesignPattern.ChainOfResponsibility.Controllers
{
    public class DefaultController : Controller
    {
        Context context = new Context();
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(CustomerProcessViewModel model)
        {
            Employee teller = new Teller(context);
            Employee assistantBranchManager = new AssistantBranchManager(context);
            Employee branchManager = new BranchManager(context);
            Employee areaDirector = new AreaDirector(context);

            teller.SetNextApprover(assistantBranchManager);
            assistantBranchManager.SetNextApprover(branchManager);
            branchManager.SetNextApprover(areaDirector);

            teller.ProcessRequest(model);
            return View();
        }
    }
}
