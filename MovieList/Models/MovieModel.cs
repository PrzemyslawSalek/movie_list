using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieList.Models
{
    public class MovieModel
    {
        public int MovieId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Watched { get; set; }
    }
}