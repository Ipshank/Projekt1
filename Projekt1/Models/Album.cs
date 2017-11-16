using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Projekt1.Models
{
    public class Album
    {

        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Author { get; set; }



        public virtual ICollection<File> Files { get; set; }
    }

    public class AlbumDBctxt : DbContext
    {
        public DbSet<Album> Albums { get; set; }

        public DbSet<File> Files { get; set; }
    }
}