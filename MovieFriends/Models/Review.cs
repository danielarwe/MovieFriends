using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MovieFriends.Models
{
    public enum MpaaRating { NR, G, PG, PG13, R, NC17 }

    public class Review
    {
        public Review()
        {
        }
        public int ReviewId { get; set; }

        [Required(ErrorMessage ="You must provide a movie title.")]
        public string Title { get; set; }

        [Display(Name ="Starring")]
        public string Actors { get; set; }

        [Display(Name = "Rated")]
        public MpaaRating Rating { get; set; }

        public string Summary { get; set; }
        public string Genre { get; set; }

        [Required(ErrorMessage ="Please provide your first name.")]
        [Display(Name = "First Name")]
        public string ReviewerFirstName { get; set; }

        [Required(ErrorMessage ="Please provide your last name.")]
        [Display(Name = "Last Name")]
        public string ReviewerLastName { get; set; }

        [Required(ErrorMessage ="You must rate this movie.")]
        [Display(Name = "Star Rating")]
        public int ReviewerRating { get; set; }

        public string Comments { get; set; }
    }
}