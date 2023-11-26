using Microsoft.AspNetCore.Mvc;
using MVCWebApp.Models;

namespace MVCWebApp.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Add()
        {
            AddEmployeeViewModel model = new()
            {
                Name = "ducdoom"
            };
            return View(model);
        }

        public IActionResult Save(AddEmployeeViewModel model)
        {

            string a = model.Name;
            return View();
        }

    }
}
