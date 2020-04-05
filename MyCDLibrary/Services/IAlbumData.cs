using MyCDLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyCDLibrary.Services
{
    public interface IAlbumData
    {
        IEnumerable<Album> GetAll();
        Album GetAlbumById(int id);
        void Add(Album album);
    }
}
