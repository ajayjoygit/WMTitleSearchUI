using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WarnerMedia.ViewModels;

namespace WarnerMedia.Controllers
{
    public class AppController: Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(TitleViewModel model)
        {
            if (ModelState.IsValid)
            {
                //Return the list of results 
            }
            else
            {
                //No results found
            }

            return View();
        }

        [HttpGet("title")]
        public IActionResult  Title()
        {
            return View();
        }

        [HttpPost("viewAll")]
         public IActionResult ViewMatchedTitles()
        {
            return View();
        }

    }
}
