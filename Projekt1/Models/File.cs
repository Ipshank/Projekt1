using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Projekt1.Models
{
    public class File
    {

        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Path { get; set; }

        public DateTime Created { get; set; }

        public int GenreID { get; set; }

        public int TypeID { get; set; }

        public int AlbumID { get; set; }


        public virtual Genre Genre { get; set; }
        public virtual Type Type { get; set; }
        public virtual Album Album { get; set; }


        public virtual ICollection<Playlist> Playlists { get; set; }
        
    }

    public class FileDBCtxt : DbContext
    {
        public DbSet<File> Files { get; set; }
    }
}