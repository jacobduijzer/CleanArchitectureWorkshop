using MijnGolf.Application.UseCases;
using FluentAssertions;
using Xunit;
using System.Threading.Tasks;
using MijnGolf.Application.Entities.Messages;
using System.Threading;

namespace MijnGolf.Tests.Application.UseCases
{
    public class GetAllCoursesShould
    {
        public GetAllCoursesShould()
        {
        }

        [Fact]
        public void Construct()
        {
            var useCase = new GetAllCoursesInteractor();
            useCase.Should().BeOfType<GetAllCoursesInteractor>();
        }

        [Fact]
        public async Task ReturnCourses()
        {
            var useCase = new GetAllCoursesInteractor();
            var result = await useCase.Handle(new RetrieveCoursesRequestMessage(), new CancellationToken());
            result.Should().NotBeNull();
            result.Courses.Should().NotBeNullOrEmpty().And.HaveCount(4);
        }
    }
}
