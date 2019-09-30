using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MusicStorenadine.Models;

namespace MusicStorenadine.Models
{
    public class MusicStoreContext : DbContext
    {
        public MusicStoreContext (DbContextOptions<MusicStoreContext> options)
            : base(options)
        {
        }

        public DbSet<MusicStorenadine.Models.Genre> Genre { get; set; }

        public DbSet<MusicStorenadine.Models.Album> Album { get; set; }

        public DbSet<MusicStorenadine.Models.Song> Song { get; set; }
    }
}
