using MovieNight.Library.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace MovieNight.Tests
{
    public class VotingTest
    {
        [Fact]
        public void Test_VotingId()
        {
            var expected = typeof(Guid);
            var sut = new Voting();
            var actual = sut.Id;
            Assert.True(expected == actual.GetType());
        }
    }
}
