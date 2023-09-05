using Calculator_MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace Calculator_MVC.Controllers
{
    public class EMIController : Controller
    {
        public ActionResult Index() 
        {
            return View(new EMI());
        }
        [HttpPost]
        public IActionResult Index(EMI emi)
        {
            int a, t;
            double r,x1,y1,t1,x2,t2;
            a = emi.Amount;
            r = emi.Rate/(100 * 12);
            t = emi.Time*12;
            y1 = r + 1;
            x1 = Math.Pow(y1, t);
            t1 = r * x1;
            x2 = Math.Pow(y1, t);
            t2 = x2 - 1;            
            emi.Total = a * (t1/t2);
            ViewData["result"] = emi.Total;

            return View();
        }
    }
}
