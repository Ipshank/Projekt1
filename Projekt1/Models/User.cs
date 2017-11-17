using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Projekt1.Models
{
    public class User
    {

        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
    } public virtual ICollection<Playlist> Playlists { get; set; }

    public class UserDBCtxt: DbContext
    {
        public DbSet<User> Users { get; set; }
    }
}