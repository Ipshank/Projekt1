using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Projekt1.Models
{
    public class Type
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }



        public virtual ICollection<File> Files { get; set; }

    }

    public class TypeDBctxt : DbContext
    {
        public DbSet<Type>  Types { get; set; }

        public DbSet<File> Files { get; set; }
    }
}