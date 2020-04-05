using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MyCDLibrary.Entities
{
    public class MyCDLibraryContext: DbContext
    {
        public DbSet<Album> Albums { get; set; }

        public MyCDLibraryContext(DbContextOptions options) : base(options)
        {

        }
    }
}
