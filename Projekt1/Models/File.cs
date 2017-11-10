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

        
    }

    public class FileDBCtxt : DbContext
    {
        public DbSet<File> Files { get; set; }
    }
}