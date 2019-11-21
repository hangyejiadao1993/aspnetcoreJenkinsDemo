using System.Linq;
using frontend.Model;
using Microsoft.AspNetCore.Mvc;

namespace frontend.Controllers
{
    public class CustomerController : Controller
    {
        private readonly MyAppDbContext context = null;

        public CustomerController(MyAppDbContext _contenxt)
        {
            this.context = _contenxt;
        }
        public IActionResult Index()
        {
            var customers = this.context.Customers.ToList();
            return View(customers);
        }
    }
}