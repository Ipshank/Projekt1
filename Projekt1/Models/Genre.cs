using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Projekt1.Models
{
    public class Genre
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }



        public virtual ICollection<File> Files { get; set; }


    }

    public class GenreDBCtxt : DbContext
    {
        public DbSet<Genre> Genres { get; set; }

        public DbSet<File> Files { get; set; }
    }
}