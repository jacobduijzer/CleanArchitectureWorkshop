using FluentAssertions;
using MijnGolf.Application.Data.Specifications;
using Xunit;

namespace MijnGolf.Tests.Application.Data.Specifications
{
    public class AllCoursesSpecificationShould
    {
        public AllCoursesSpecificationShould()
        {
        }

        [Fact]
        public void Construct()
        {
            var specification = new AllCoursesSpecification();

            specification.Should()
                         .BeOfType<AllCoursesSpecification>();
        }
    }
}
