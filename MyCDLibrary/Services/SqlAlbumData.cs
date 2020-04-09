using MyCDLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MyCDLibrary.Services
{
    public class SqlAlbumData : IAlbumData
    {
        private readonly MyCDLibraryContext _context;

        public SqlAlbumData(MyCDLibraryContext context)
        {
            _context = context;
        }
        public void Add(Album album)
        {
            _context.Add(album);
            _context.SaveChanges();
        }

        public Album GetAlbumById(int id)
        {
            return _context.Albums.FirstOrDefault(a => a.Id == id);
        }

        public IEnumerable<Album> GetAll()
        {
            return _context.Albums.OrderBy(a => a.Artist);
        }

        public void Update(Album album)
        {
            var entry = _context.Entry(album);
            entry.State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
