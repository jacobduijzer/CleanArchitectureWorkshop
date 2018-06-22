using Xunit;
using MijnGolf.Domain.Entities;
using FluentAssertions;

namespace MijnGolf.Tests.Domain.Entities
{
    public class HoleShould
    {
        public HoleShould()
        {
        }

        [Fact]
        public void Construct()
        {
            var hole = new Hole(1, 4);

            hole.Should()
                .BeOfType<Hole>();
            
            hole.HoleNumber
                .Should()
                .Be(1);
            
            hole.NumberOfStrokes
                .Should()
                .Be(4);
        }
    }
}
