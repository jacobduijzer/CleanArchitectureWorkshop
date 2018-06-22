using FluentAssertions;
using MijnGolf.Application.Entities.Messages;
using Xunit;

namespace MijnGolf.Tests.Application.Entities.Messages
{
    public class RetrieveCoursesRequestMessageShould
    {
        public RetrieveCoursesRequestMessageShould()
        {
        }

        [Fact]
        public void Construct()
        {
            var requestMessage = new RetrieveCoursesRequestMessage();
            requestMessage.Should()
                          .BeOfType<RetrieveCoursesRequestMessage>();
        }
    }
}
