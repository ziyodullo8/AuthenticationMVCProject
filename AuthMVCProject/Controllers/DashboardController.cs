using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AuthMVCProject.Controllers
{
   // [Authorize]
    public class DashboardController : Controller
    {
        public IActionResult Display ()
        {
            return View();
        }
    }
}
