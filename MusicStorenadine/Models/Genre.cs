using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MusicStorenadine.Models
{
    public class Genre
    {
        [Key]
        public int GenreID { get; set; }

        public string Name { get; set; }

        public ICollection<Album> Albums { get; set; }

    }
}
