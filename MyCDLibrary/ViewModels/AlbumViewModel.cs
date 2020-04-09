using MyCDLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyCDLibrary.ViewModels
{
    public class AlbumViewModel
    {
        public IEnumerable<Album> Albums { get; set; }
    }
}
