﻿using MovieNight.Library.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace MovieNight.Tests
{
    public class HistoryTests
    {
        [Fact]
        public void Test_HistoryId()
        {
            var expected = typeof(Guid);
            var sut = new History();
            var actual = sut.Id;

            Assert.True(expected == actual.GetType());
        }

        [Fact]
        public void Test_HistoryMovies()
        {
            var expected = 1;
            var sut = new History();
            var actual = sut.Movies;

            Assert.True(typeof(List<Movie>) == actual.GetType());
            Assert.True(expected <= actual.Count);
        }
    }
}
