using Microsoft.AspNetCore.Mvc;
using PartialViewDemo.Models;

namespace PartialViewDemo.Controllers
{

   
    
    public class EmployeeController : Controller
    {
        private readonly ApplicationDbContext applicationDbContext;

        public EmployeeController(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }

        public IActionResult Index()
        {
            var model=applicationDbContext.Employees.ToList();  
            return View(model);
        }
    }
}
