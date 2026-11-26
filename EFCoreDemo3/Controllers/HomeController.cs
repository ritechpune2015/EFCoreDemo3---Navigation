using EFCoreDemo3.Context;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace EFCoreDemo3.Controllers
{
    public class HomeController : Controller
    {
        CompanyContext cc;
        public HomeController(CompanyContext tcc)
        {
            this.cc = tcc;
        }
        public IActionResult Index()
        {
            var res = this.cc.Emps.ToList();
            return View(res);
        }
    }
}
