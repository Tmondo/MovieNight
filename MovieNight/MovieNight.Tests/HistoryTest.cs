using MovieNight.Library.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace MovieNight.Tests
{
     public class HistoryTest
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
        public void Test_HistoryMovieList()
        {
            var expected = 1; //we are assuming here that everyone has seen at least one movie
            var sut = new History();
            var actual = sut.Movies;


            Assert.True(typeof(List<Movie>) == actual.GetType()); //says that everything in the history is a movie
            Assert.True(expected <= actual.Count);  //means that a history list exists
        }
    }
}
