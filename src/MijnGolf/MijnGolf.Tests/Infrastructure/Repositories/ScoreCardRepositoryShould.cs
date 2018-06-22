using MijnGolf.Infrastructure.Repositories;
using FluentAssertions;
using Xunit;

namespace MijnGolf.Tests.Infrastructure.Repositories
{
    public class ScoreCardRepositoryShould
    {
        public ScoreCardRepositoryShould()
        {
        }

        [Fact]
        public void Construct()
        {
            var scorecardRepository = new ScoreCardRepository();
            scorecardRepository.Should()
                               .BeOfType<ScoreCardRepository>();
        }
    }
}
