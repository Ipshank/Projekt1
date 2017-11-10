using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Projekt1.Models
{
    public class Playlist
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Creator { get; set; }
    }
}