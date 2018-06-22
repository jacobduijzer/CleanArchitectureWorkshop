using System;
using System.Linq.Expressions;
using MijnGolf.Application.Data.Specifications.Base;
using MijnGolf.Domain.Entities;

namespace MijnGolf.Application.Data.Specifications
{
    public class AllCoursesSpecification : Specification<Course>
    {
        public AllCoursesSpecification()
        {
        }

        public override Expression<Func<Course, bool>> ToExpression()
        {
            return item => true;
        }
    }
}
