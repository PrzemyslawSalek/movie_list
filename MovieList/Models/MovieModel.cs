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

        [Display(Name = "Nazwa:")]
        [Required(ErrorMessage = "Pole Nazwa jest wymagane")]
        [MaxLength(50)]
        public string Name { get; set; }

        [Display(Name = "Opis:")]
        [MaxLength(2000)]
        public string Description { get; set; }

        [Display(Name = "Gatunek:")]
        [MaxLength(50)]
        public string Genre { get; set; }

        [Display(Name = "Obejrzane:")]
        public bool Watched { get; set; }
    }
}