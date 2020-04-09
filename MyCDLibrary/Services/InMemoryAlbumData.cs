using MyCDLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyCDLibrary.Services
{
    public class InMemoryAlbumData : IAlbumData
    {
        private static List<Album> _albums;
        static InMemoryAlbumData()
        {
            _albums = new List<Album>()
            {
                new Album(1, "The Antlers", new DateTime(2009,3,23), "Hospice"),
                new Album(2, "Sufjan Stevens", new DateTime(2004,3,16), "Seven Swans")
            };
        }

        public void Add(Album album)
        {
            album.Id = _albums.Max(a => a.Id) + 1;
            _albums.Add(album);
        }

        public Album GetAlbumById(int id)
        {
            return _albums.FirstOrDefault(a => a.Id == id);
        }

        public IEnumerable<Album> GetAll()
        {
            return _albums.OrderBy(a => a.Title);
        }

        public void Update(Album album)
        {
            throw new NotImplementedException();
        }
    }
}
