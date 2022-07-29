using Microsoft.AspNetCore.Mvc;

namespace DiemPortal.Controllers
{
    public class IdentityRoleManager : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
