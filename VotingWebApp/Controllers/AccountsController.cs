using Microsoft.AspNetCore.Mvc;

namespace VotingWebApp.Controllers
{
    public class Accounts : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
