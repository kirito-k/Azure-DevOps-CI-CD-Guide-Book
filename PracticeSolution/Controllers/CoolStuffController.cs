using System.Reflection.Metadata.Ecma335;
using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Mvc;

namespace PracticeSolution.Controllers
{
    public class CoolStuffController : Controller
    {
        // GET
        
        public IActionResult Index()
        {
            return View();
        }

        public string JustName()
        {
            return "Rick the dick";
        }

        public IActionResult MoreCool(int Age, string Name)
        {
            ViewData["Name"] = Name;
            ViewData["Age"] = Age;

            //            return HtmlEncoder.Default.Encode($"This is the name = {Name}, and whatever number = {Roll}");
            return View();
        }
    }
}