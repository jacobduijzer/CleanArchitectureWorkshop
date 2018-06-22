using MijnGolf.Application.Data.Specifications;
using FluentAssertions;
using Xunit;

namespace MijnGolf.Tests.Application.Data.Specifications
{
    public class CourseByIdSpecificationShould
    {
        public CourseByIdSpecificationShould()
        {
        }

        [Fact]
        public void Construct()
        {
            var specification = new CourseByIdSpecification(2);

            specification.Should()
                         .BeOfType<CourseByIdSpecification>();
        }
    }
}
