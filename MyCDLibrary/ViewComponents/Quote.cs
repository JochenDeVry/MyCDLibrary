using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyCDLibrary.Services;

namespace MyCDLibrary.ViewComponents
{
    public class Quote: ViewComponent
    {
        private IQuoter _quoter;

        public Quote(IQuoter quoter)
        {
            _quoter = quoter;
        }

        public IViewComponentResult Invoke()
        {
            var model =  _quoter.GetQuoteOfTheDay();
            return View("Default", model);
        }
    }
}
