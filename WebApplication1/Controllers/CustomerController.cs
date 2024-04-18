using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class CustomerController : Controller
    {
       static List<Customer> customers = new List<Customer>()
  {
          new Customer {Id = 1, Name = "awdhah",Email = "12@gmail.com",PhoneNumber = "1234"},
      new Customer {Id = 2, Name = "fatmah",Email = "12@gmail.com",PhoneNumber = "1234"}
  };
          public IActionResult Index()
          {

              return View(customers);
          }
           public IActionResult Register()
            {

                return View();
            }
           [ HttpPost]
        public IActionResult Register(RegisterCustomerForm model)
{
            if (ModelState.IsValid)
            {
                var name = model.Name;
                var email = model.Email;
                var phoneNumber = model.PhoneNumber;
                var favoriteColor = model.FavoriteColor;
                var dateOF = model.DateOfBirth;

                var c = new Customer();
                c.Name = name;
                c.Email = email;
                c.PhoneNumber = phoneNumber;
                c.FavoriteColor = favoriteColor;
                c.DateOfBirth = dateOF;
                customers.Add(c);


                return RedirectToAction("Index");

            }
            return View("Register");
          
}




        } 

} 


        /* private static List<Customer> customers = new List<Customer>();

        public IActionResult Index()
        {
            return View(customers);
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(Customer customer)
        {
            if (ModelState.IsValid)
            {
                customer.Id = customers.Count + 1;
                customers.Add(customer);
                return RedirectToAction("Index");
            }

            return View(customer);
        }
    }


}*/




