using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FirstAspNetCore.Models;

namespace FirstAspNetCore.Controllers
{
    public class PersonController : Controller
    {
        public IActionResult Index(){

            List<Person> listPersons=new List<Person>();
            listPersons.Add(new Person(1,"Thomas","Torelle",new DateTime(1985,2,11), "85021165987"));
            listPersons.Add(new Person(2,"Eve","Dev", new DateTime(1991,12,11), "91121165987"));
            listPersons.Add(new Person(3, "Andreas","Bink", new DateTime(1978,6,12), "78061200789"));
            listPersons.Add(new Person(4, "Paola","Linden", new DateTime(1995,12,21), "95122165753"));
            
            return View(listPersons);
        }
    }

}