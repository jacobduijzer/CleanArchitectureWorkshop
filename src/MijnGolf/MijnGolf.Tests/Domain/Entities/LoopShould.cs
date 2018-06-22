using MijnGolf.Domain.Entities;
using Xunit;
using FluentAssertions;

namespace MijnGolf.Tests.Domain.Entities
{
    public class LoopShould
    {
        public LoopShould()
        {
        }

        [Fact]
        public void Construct()
        {
            var loop = new Loop(1, 18);

            loop.Should()
                .BeOfType<Loop>();

            loop.Id
                .Should()
                .Be(1);

            loop.NumberOfHoles
                .Should()
                .Be(18);
        }
    }
}
