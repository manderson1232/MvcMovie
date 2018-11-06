﻿using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovie.Models
{
    public class MovieGenreViewModel
    {
        public List<Movie> Movies;
        public SelectList Genres;
        public string MovieGenre { get; set; }
        public string SearchString { get; set; }
    }
    public class ReviewViewModel

    {
        public List<MvcMovie.Models.Review> ReviewerName { get; set; }
        public List<String> ReviewBody { get; set; }
    }
}