using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Projekt1.Models
{
    public class Playlist
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Creator { get; set; }


        public virtual User User { get; set; }


        public virtual ICollection<File> Files { get; set; }
    }

    public class PlaylistDBCtxt: DbContext
    {
        public DbSet<Playlist> Playlists { get; set; }
    }
}