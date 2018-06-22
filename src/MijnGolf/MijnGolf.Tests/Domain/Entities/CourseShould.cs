using System.Collections.Generic;
using MijnGolf.Domain.Entities;
using Xunit;
using FluentAssertions;

namespace MijnGolf.Tests.Domain.Entities
{
    public class CourseShould
    {
        public CourseShould()
        {
        }

        [Fact]
        public void Construct()
        {
            var course = new Course(1, "Test course", new List<Loop>
            {
                new Loop(1, 9),
                new Loop(2, 18),
            });

            course.Should()
                  .BeOfType<Course>();

            course.Id
                  .Should()
                  .Be(1);

            course.Name
                  .Should()
                  .Be("Test course");

            course.Loops
                  .Should()
                  .NotBeNullOrEmpty()
                  .And
                  .HaveCount(2);
        }
    }
}
