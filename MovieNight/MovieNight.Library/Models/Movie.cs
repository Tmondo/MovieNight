﻿using MovieNight.Library.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieNight.Library.Models
{
   public class Movie : AModel
    {
        public List<Actor> Actor
        {
            get;
            set;

        }
        public Movie()
        {
            Actor = new List<Actor>()
            {
                new Actor()
            };
        }
    }
}
