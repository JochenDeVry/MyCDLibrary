using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyCDLibrary.Entities
{
    public enum AlbumRating
    {
        None,
        Masochism,
        Bad,
        Meh,
        Good,
        Superb
    }
    public class Album
    {
        public Album()
        {
            
        }
        
        public Album(int Id, string Artist, DateTime ReleaseDate, string Title)
        {
            this.Id = Id;
            this.Artist = Artist;
            this.ReleaseDate = ReleaseDate;
            this.Title = Title;
        }
        public int Id { get; set; }

        [Required, MaxLength(80)]
        public string Artist { get; set; }

        [DataType(DataType.Date)]
        //[DisplayFormat(ApplyFormatInEditMode =true, DataFormatString = "{0:dd/MM/yyyy}")]
        [Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }

        [Required, MaxLength(160)]
        public string Title { get; set; }

        public IEnumerable<Track> TrackList { get; set; }

        [Display(Name ="Album rating")]
        public AlbumRating Rating { get; set; }
    }
}
