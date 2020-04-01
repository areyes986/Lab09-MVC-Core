using FirstMVCApp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstMVCApp.Controllers
{
    public class HomeController : Controller
    {

        /// <summary>
        /// Default home route on home page
        /// </summary>
        /// <returns> Generated view </returns>
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(int begYear, int endYear)
        {
            //needs to redirect to our results action with the "results" of our query
            List<TimePerson> persons = TimePerson.GetPersons(begYear, endYear);

            return RedirectToAction(persons.ToString());


        }

        public IActionResult results(List<TimePerson>persons)
        {
            return View(persons);
        }


    }
}
