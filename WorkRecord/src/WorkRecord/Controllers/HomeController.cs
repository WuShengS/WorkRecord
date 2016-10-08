using Microsoft.AspNetCore.Mvc;
using WorkRecord.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorkRecord.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var entry = new Employee() { Name = "John1", LastName = "Winston1" };
            using (var context = EmployeesContextFactory.Create(Startup.ConnectionString))
            {
                context.Add(entry);
                context.SaveChanges();
            }
            ViewData["Message"] = "Sucdess";
            return View();
        }
    }
}
