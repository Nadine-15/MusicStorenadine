using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MusicStorenadine.Models
{
    public class Song
    {
        [Key]

        public int SongID { get; set; }

        [ForeignKey("Album")]
        public int AlbumID { get; set; }

        public string SongName { get; set; }

        public string Artist { get; set; }

        public string Featuring { get; set; }

        public int RunTimeSeconds { get; set; }

        public DateTime ReleaseDate { get; set; }

        public ICollection<Song> Songs { get; set; }


    }
}
