using Microsoft.AspNetCore.Mvc;

namespace SampleMvcApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(string originator = null)
        {
            if(originator != null) 
            {
                return RedirectToAction("Login", "Account", new {returnTo="/", originator = originator});
            }            
            else 
            {
                return View();
            }
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
