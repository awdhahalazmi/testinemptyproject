using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class EmployeeController : Controller
    {
        List<Employee> employees = new List<Employee>()
        {
           new Employee { Id = 1,FirstName = "Awdhah", LastName = "Alazmi", EmployeeId = 1, Email = "123@gmail.com", Department = "IT" },
            new Employee { Id= 2,FirstName = "Fatmah", LastName = "Buyabes", EmployeeId = 2, Email = "123@gmail.com", Department = "IT" },
            new Employee {Id=3, FirstName = "Haya", LastName = "Alqahtany", EmployeeId = 3, Email = "1273@gmail.com", Department = "IT" }


        };

        public IActionResult Index()
        {


            return View(employees);
        }
        public IActionResult Details(int id)
        {
            var employee = employees.SingleOrDefault(a => a.Id == id);
            if (employees == null)
            {
                return RedirectToAction("Index");

            }
            return View(employee);
        }
        public IActionResult Register()
        {
            return View();
        }
       
    }

}
