using IdentityApp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityApp.Controllers
{
    public class CustomerController : Controller
    {
        
        [HttpGet]
        public IActionResult Index(string id)
        {
            CustomersManager manager = new CustomersManager();
            AspNetCustomers customer = manager.FindCustomer(id);
            return View(customer);
        }
    }
}
