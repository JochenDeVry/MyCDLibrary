using Microsoft.AspNetCore.Mvc;
using MyCDLibrary.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyCDLibrary.Entities;
using MyCDLibrary.Services;

namespace MyCDLibrary.Controllers
{
    [Route("[Controller]/[Action]/{id:int?}")]
    public class AlbumController: Controller
    {
        private IAlbumData _albumData;
        private IQuoter _quoter;

        public AlbumController(IAlbumData albumData, IQuoter quoter)
        {
            _albumData = albumData;
            _quoter = quoter;
        }

        public IActionResult Index()
        {
            //return new ObjectResult(_albums); //use this to return an albumobject, which will ebe serialized into JSON
            //var model = _albumData.GetAll();
            var model = new AlbumViewModel();
            model.Albums = _albumData.GetAll();
            model.CurrentQuote = _quoter.GetQuoteOfTheDay();
            return View("Index", model);
        }

        public IActionResult Detail(int id)
        {
            var model = _albumData.GetAlbumById(id);
            if (model == null)
            {
                return RedirectToAction("Index"); // redirects to this controller's action List()
            }
            return View("Detail", model);
        }

        [HttpGet]
        public ViewResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(AlbumEditViewModel model)
        {
            if (ModelState.IsValid)
            {
                var album = new Album();
                album.Artist = model.Artist;
                album.Title = model.Title;
                album.Rating = model.Rating;
                album.ReleaseDate = model.ReleaseDate;
                _albumData.Add(album);
                return RedirectToAction("Detail", new { id = album.Id });
            }

            return View();
        }
    }
}
