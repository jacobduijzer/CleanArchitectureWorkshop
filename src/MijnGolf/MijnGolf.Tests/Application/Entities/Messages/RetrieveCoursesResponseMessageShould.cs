using FluentAssertions;
using MijnGolf.Application.Entities.Messages;
using Xunit;
using System.Collections.Generic;
using MijnGolf.Domain.Entities;

namespace MijnGolf.Tests.Application.Entities.Messages
{
    public class RetrieveCoursesResponseMessageShould
    {
        public RetrieveCoursesResponseMessageShould()
        {
        }

        [Fact]
        public void Construct()
        {
            var fakeCourses = new List<Course>
            {
                new Course(1, "Test course", new List<Loop>
                {
                    new Loop(1, 9),
                    new Loop(2, 18),
                }),
            };

            var responseMessage = new RetrieveCoursesResponseMessage(fakeCourses);

            responseMessage.Should()
                           .BeOfType<RetrieveCoursesResponseMessage>();

            responseMessage.Courses
                           .Should()
                           .NotBeNullOrEmpty()
                           .And
                           .HaveCount(1);
        }
    }
}
