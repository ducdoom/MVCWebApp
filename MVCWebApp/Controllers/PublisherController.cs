using Microsoft.AspNetCore.Mvc;
using MVCWebApp.Models;

namespace MVCWebApp.Controllers
{
    public class PublisherController : Controller
    {
        private PublisherViewModel publisherViewModel = new();
        public async Task<IActionResult> Index()
        {
            await publisherViewModel.GetUserDashboard();
            return View(publisherViewModel);
        }
    }
}
