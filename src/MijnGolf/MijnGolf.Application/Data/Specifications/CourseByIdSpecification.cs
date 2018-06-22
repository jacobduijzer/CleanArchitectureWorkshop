using System;
using System.Linq.Expressions;
using MijnGolf.Application.Data.Specifications.Base;
using MijnGolf.Domain.Entities;

namespace MijnGolf.Application.Data.Specifications
{
    public class CourseByIdSpecification : Specification<Course>
    {
        private readonly int _id;

        public CourseByIdSpecification(int id)
        {
            _id = id;
        }

        public override Expression<Func<Course, bool>> ToExpression()
        {
            return course => course.Id.Equals(_id);
        }
    }
}