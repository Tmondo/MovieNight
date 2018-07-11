using MovieNight.Library.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace MovieNight.Tests
{
     public class MovieTest
    {
        [Fact]
        public void Test_MovieId()
        {
            var expected = typeof(Guid);
            var sut = new Movie();
            var actual = sut.Id;
            Assert.True(expected == actual.GetType());
        }

        [Fact]
        public void Test_MovieActors()
        {
            var expected = 1; //we are assuming here that everyone has seen at least one movie
            var sut = new Movie();
            var actual = sut.Actor;


            Assert.True(typeof(List<Person>) == actual.GetType()); //says that everything in the history is a movie
            Assert.True(expected <= actual.Count);  //means that a history list exists
        }
    }
}
