using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMovie.Models
{
    public class Movie
    {
        public int ID { get; set; }
        [StringLength(60, MinimumLength = 2, ErrorMessage = "Title must be between 2 to 60 characters"), Required]
        public string Title { get; set; }
        [Display(Name = "Release Date"), DataType(DataType.Date), Required]
        [DisplayFormat(DataFormatString = "{0:MMMM dd, yyyy}")]
        public DateTime ReleaseDate { get; set; }
        
        [Required]
        [StringLength(30, ErrorMessage = "The field Genre must be no more than 30 characters")]
        public string Genre { get; set; }

        [Range(1, 100), DataType(DataType.Currency), Required]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }
        [Required]
        public string Rating { get; set; }
        public string PosterURL { get; set; }
    }

}
