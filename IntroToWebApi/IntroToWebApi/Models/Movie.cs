﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IntroToWebApi.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public string Director { get; set; }
        public DateTime ReleaseDate { get; set; }
        public List<Actor> Actors { get; set; }

    }
}