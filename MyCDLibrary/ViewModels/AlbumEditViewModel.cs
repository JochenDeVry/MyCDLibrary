using MyCDLibrary.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyCDLibrary.ViewModels
{
    public class AlbumEditViewModel
    {
        [Required, MaxLength(80)]
        public string Artist { get; set; }

        [Required, MaxLength(160)]
        public string Title { get; set; }

        public AlbumRating Rating { get; set; }

        public DateTime ReleaseDate { get; set; }
    }
}
