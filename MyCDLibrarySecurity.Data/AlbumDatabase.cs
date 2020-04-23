using System;
using System.Collections.Generic;
using System.Text;

namespace MyCDLibrarySecurity.Data
{
    public class AlbumDatabase
    {
        public int Id { get; set; }
        public string AlbumDataBaseId { get; set; }
        public User user { get; set; }
        public int UserId { get; set; }
    }
}
