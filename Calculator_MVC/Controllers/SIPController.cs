using Calculator_MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace Calculator_MVC.Controllers
{
    public class SIPController : Controller
    {
        public ActionResult Index()
        {
            return View(new SIP());
        }
        [HttpPost]
        public IActionResult Index(SIP sip)
        {
            int a, t;
            double r, x1, y1, t1, t2;
            a = sip.Amount;
            r = sip.Rate / (100 * 12);
            t = sip.Time * 12;
            y1 = r + 1;
            x1 = Math.Pow(y1, t);
            t1 = a * (x1-1);
            t2 = (1 + r) / r;
            sip.Total = t1*t2;
            ViewData["result"] = sip.Total;

            return View();
        }
    }
}
