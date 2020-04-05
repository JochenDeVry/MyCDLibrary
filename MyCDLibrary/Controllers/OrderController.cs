using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc; // needed for mvc attribute routes

namespace MyCDLibrary.Controllers
{
    //[Route("Order")] //same as the following
    //[Route("[controller]")]
    [Route("[controller]/[action]")]
    public class OrderController: Controller
    {
        //[Route("Cd")] //same as the following
        //[Route("[action]")]
        public IActionResult Cd()
        {
            return Content("This is where you can expand your music collection with the latest and greatest.");
        }

        //[Route("Artist")]
        public string Artist()
        {
            return "Single Compact Stereo Discs not enough? Buy the entire discography of your favourite band here.";
        }

        //[Route("")]
        public string Home()
        {
            return "This is an attribute route using MVC where you can order music. Purchase single CD's or entire catalogues.";
        }
    }
}
