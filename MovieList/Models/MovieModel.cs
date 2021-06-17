using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MovieList.Models
{
    public class MovieModel
    {
        public int MovieId { get; set; }

        [Display(Name = "Nazwa")]
        public string Name { get; set; }

        [Display(Name = "Opis")]
        public string Description { get; set; }

        [Display(Name = "Obejrzane")]
        public bool Watched { get; set; }
    }
}