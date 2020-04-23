using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyCDLibrarySecurity.Data
{
    public class AlbumSecurityContext : IdentityDbContext<User, Role, int>
    {
        public DbSet<AlbumDatabase> AlbumDatabases { get; set; }

        public AlbumSecurityContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<AlbumDatabase>().Property(es => es.AlbumDataBaseId).IsRequired();
            base.OnModelCreating(builder);
        }
    }
}
