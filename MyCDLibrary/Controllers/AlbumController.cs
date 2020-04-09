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

        public AlbumController(IAlbumData albumData, IQuoter quoter)
        {
            _albumData = albumData;
        }

        public IActionResult Index()
        {
            //return new ObjectResult(_albums); //use this to return an albumobject, which will ebe serialized into JSON
            //var model = _albumData.GetAll();
            var model = new AlbumViewModel();
            model.Albums = _albumData.GetAll();
            return View("Index", model);
        }

        public IActionResult Detail(int id)
        {
            var model = _albumData.GetAlbumById(id);
            if (model == null)
            {
                return RedirectToAction("Index"); // redirects to this controller's action Index()
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

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var model = _albumData.GetAlbumById(id);
            if (model == null)
            {
                return RedirectToAction(nameof(Index));
            }
            return View(model);
        }

        [HttpPost]
        public IActionResult Edit(int id, AlbumEditViewModel model)
        {
            var album = _albumData.GetAlbumById(id);
            if (album != null && ModelState.IsValid)
            {
                album.Artist = model.Artist;
                album.Rating = model.Rating;
                album.ReleaseDate = model.ReleaseDate;
                album.Title = model.Title;
                album.TrackList = model.TrackList;
                _albumData.Update(album);
                return RedirectToAction(nameof(Detail), new {id = album.Id});
            }
            return View(model);
        }
    }
}
