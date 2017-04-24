using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace FirstAspNetCore.Controllers
{
    public class IndexController : Controller
    {
        public string Index()
        {
            return "My first controller works perfectly :)";
        }

        public string Welcome(string name, string lastName)
        {
            return HtmlEncoder.Default.Encode($"Hello {name} {lastName}");
        }

        public IActionResult Contact(){
            return View();
        }

        public IActionResult Information(){

            ViewData["Company"]="MyCompany Example Ltd.";
            ViewData["Address"]="Bridge 12, MyTown";
            ViewData["Phone"]="123-456-789";

            return View();
        }

        public IActionResult Iteration(int from, int to)
        {
            ViewData["from"]=from;
            ViewData["to"]=to;
            
            return View();
        }

    }
}
