using Basics.Models;
using Microsoft.AspNetCore.Mvc;

namespace Basics.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index1()
        {
            string message = $"hello{DateTime.Now.ToString()}";
            return View("Index1",message);
        }
        public ViewResult Index2()
        {
            var names = new string[]{
                "A",
                "M",
                "C",
            };
            return View(names);
        }

        public IActionResult Index3()
        {
            var list = new List<Employee>()
            {
                new Employee(){Id=1,FirstName="Ali", LastName="Veli",Age=20},
                new Employee(){Id=2,FirstName="Veli", LastName="Ali",Age=30}
                
            };
            return View("Index3",list);
        }

    }
}