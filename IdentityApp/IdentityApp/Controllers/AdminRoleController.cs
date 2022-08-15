using IdentityApp.Areas.Identity;
using IdentityApp.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityApp.Controllers
{
    [Authorize(Roles = "Admin")]
   
    public class AdminRoleController : Controller
    {
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly UserManager<CustomUser> userManager;

        public AdminRoleController(RoleManager<IdentityRole> roleManager, UserManager<CustomUser> userManager)
        {
            this.roleManager = roleManager;
            this.userManager = userManager;
        }

        public IActionResult Index()
        {
            var values = roleManager.Roles.ToList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddRole()
        {
            return View();
        }
       
        [HttpPost]
        public async Task<IActionResult> AddRole(RoleViewModel model)
        {
            if(ModelState.IsValid)
            {
                
                
                IdentityRole role = new IdentityRole
                {
                    Name = model.name
                };
                var result = await roleManager.CreateAsync(role);
                if(result.Succeeded)
                {
                    Console.WriteLine("ife girdi");
                    return RedirectToAction("Index");
                }
                foreach(var item in result.Errors)
                {
                    ModelState.AddModelError("", item.Description);
                }
            }
            return View(model);
        }
        [HttpGet]
        public IActionResult UpdateRole(string id)
        {
            var values = roleManager.Roles.FirstOrDefault(x => x.Id == id);
            RoleUpdateViewModel model = new RoleUpdateViewModel
            {
                Id = values.Id,
                name= values.Name
            };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateRole(RoleUpdateViewModel model)
        {
            var values = roleManager.Roles.Where(x => x.Id == model.Id).FirstOrDefault();
            values.Name = model.name;
            var result = await roleManager.UpdateAsync(values);
            if(result.Succeeded)
            {
                return RedirectToAction("Index");
            }
            return View(model);
        }

        public async Task<IActionResult> DeleteRole(string id)
        {
            var values = roleManager.Roles.FirstOrDefault(x => x.Id == id);
            var result = await roleManager.DeleteAsync(values);
            if(result.Succeeded)
            {
                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult UserRoleList()
        {
            var values = userManager.Users.ToList();
            return View(values);
        }
        
        [HttpGet]
        public async Task<IActionResult> AssignRole(string id)
        {
            var user = userManager.Users.FirstOrDefault(x => x.Id == id);
            var roles = roleManager.Roles.ToList();

            TempData["UserId"] = user.Id;

            var userRoles = await userManager.GetRolesAsync(user);
            List<RoleAssignViewModel> model = new List<RoleAssignViewModel>();
            foreach(var item in roles)
            {
                RoleAssignViewModel m = new RoleAssignViewModel();
                m.RoleId = item.Id;
                m.Name = item.Name;
                m.Exists = userRoles.Contains(item.Name);
                model.Add(m);
            }
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> AssignRole(List<RoleAssignViewModel> model)
        {
            var userid = TempData["UserId"];
            var user = userManager.Users.FirstOrDefault(x => x.Id == userid.ToString());
            foreach(var item in model)
            {
                if(item.Exists)
                {
                    await userManager.AddToRoleAsync(user, item.Name);
                }
                else
                {
                    await userManager.RemoveFromRoleAsync(user, item.Name);
                }
            }
            return RedirectToAction("UserRoleList");
        }

        public IActionResult CustomerList()
        {
            CustomersManager manager = new CustomersManager();
            List<AspNetCustomers> list = manager.ReadCustomer();
            return View(list);
        }
        [HttpGet]
        public IActionResult AddCustomer()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddCustomer(AspNetCustomers model)
        {
            CustomersManager manager = new CustomersManager();
           int results = manager.AddCustomer(model);
            if(results == 1)
            {
                return RedirectToAction("CustomerList");
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult UpdateCustomer(string id)
        {
            CustomersManager manager = new CustomersManager();
            var customer = manager.FindCustomer(id);

            return View(customer);
        }
        [HttpPost]
        public IActionResult UpdateCustomer(AspNetCustomers customer)
        {
            CustomersManager manager = new CustomersManager();
            int results = manager.UpdateCustomer(customer);
            if(results==1)
            {
                return RedirectToAction("CustomerList");
            }
            return View(customer);
        }
        [HttpGet]
        public IActionResult DeleteCustomer(string id)
        {
            CustomersManager manager = new CustomersManager();
            manager.DeleteCustomer(id);
           
            return RedirectToAction("CustomerList");
        }
    }
}
