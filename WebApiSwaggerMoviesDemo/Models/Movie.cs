﻿using System;

namespace WebApiSwaggerMoviesDemo.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Classification { get; set; }
        public DateTime? ReleaseDate { get; set; }
    }
}
