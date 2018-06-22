using FluentAssertions;
using MijnGolf.Infrastructure.Repositories;
using Xunit;

namespace MijnGolf.Tests.Infrastructure.Repositories
{
    public class CourseRepositoryShould
    {
        public CourseRepositoryShould()
        {
        }

        [Fact]
        public void Construct()
        {
            var repo = new CourseRepository();
            repo.Should().BeOfType<CourseRepository>();
        }

        [Fact]
        public void ReturnCourses()
        {
            var repo = new CourseRepository();
            var courses = repo.GetAll();
            courses.Should().NotBeNullOrEmpty().And.HaveCount(4);
        }
    }
}
