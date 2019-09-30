using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MusicStorenadine.Models
{
    public class Album
    {
        [Key]
        public int AlbumID { get; set; }

        [ForeignKey("Genre")]
        public int GenreID { get; set; }

        public string Name { get; set; }

        public string Artist { get; set; }

        public DateTime ReleaseDate { get; set; }
    }

}
