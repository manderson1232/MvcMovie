using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovie.Models
{
    public class Review
    {
        public int ID { get; set; }

        [StringLength(60, MinimumLength = 2, ErrorMessage = "Name must have at least 2 characters")]
        [Required]
        public string Reviewer { get; set; }

        [StringLength(1500, MinimumLength = 10, ErrorMessage = "The review must have at least 10 characters.")]
        [Required]
        public string UserReview { get; set; }

        [Required]
        public int MovieID { get; set; }

        [Required]
        public string MovieTitle { get; set; }
    }
}
