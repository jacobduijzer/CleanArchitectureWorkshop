using FluentAssertions;
using MijnGolf.Infrastructure.Repositories;
using Xunit;
using MijnGolf.Application.Data.Specifications;

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
            repo.Should()
                .BeOfType<CourseRepository>();
        }

        [Fact]
        public void ReturnCourses()
        {
            var repo = new CourseRepository();
            var courses = repo.GetItems(new AllCoursesSpecification());
            courses.Should()
                   .NotBeNullOrEmpty()
                   .And
                   .HaveCount(4);
        }

        [Fact]
        public void ReturnCourseById()
        {
            var repo = new CourseRepository();
            var course = repo.GetItem(new CourseByIdSpecification(2));

            course.Should()
                  .NotBeNull();

            course.Id
                  .Should()
                  .Be(2);
        }
    }
}
