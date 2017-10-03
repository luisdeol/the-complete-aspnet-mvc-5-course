using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ActionResult Index()
        {
            var customers = new List<Customer>
            {
                new Customer{ Id = 1, Name = "Customer 1"},
                new Customer{ Id = 2, Name = "Customer 2"}
            };
            return View(customers);
        }

        public ActionResult Details(int id)
        {
            var customers = new List<Customer>
            {
                new Customer{ Id = 1, Name = "Customer 1"},
                new Customer{ Id = 2, Name = "Customer 2"}
            };

            if (customers.All(c => c.Id != id))
                return new HttpNotFoundResult();

            return View(customers.First(c => c.Id == id));
        }
    }
}