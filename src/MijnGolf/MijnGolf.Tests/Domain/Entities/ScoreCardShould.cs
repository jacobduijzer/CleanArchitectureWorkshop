using System;
using MijnGolf.Domain.Entities;
using System.Collections.Generic;
using Xunit;
using FluentAssertions;

namespace MijnGolf.Tests.Domain.Entities
{
    public class ScoreCardShould
    {
        public ScoreCardShould()
        {
        }

        [Fact]
        public void Construct()
        {
            var scoreCard = new ScoreCard(1, 2, 3, new List<Hole>
            {
                new Hole(1, 4),
                new Hole(2, 5),
                new Hole(3, 2)
            }, DateTime.Now);

            scoreCard.Should()
                     .BeOfType<ScoreCard>();

            scoreCard.UserId
                     .Should()
                     .Be(1);

            scoreCard.CourseId
                     .Should()
                     .Be(2);

            scoreCard.LoopId
                     .Should()
                     .Be(3);

            scoreCard.Holes
                     .Should()
                     .NotBeNullOrEmpty()
                     .And
                     .HaveCount(3);
        }
    }
}
