using System.Collections.Generic;
using MijnGolf.Domain.Entities;
using System.Linq;
using MijnGolf.Domain.Contracts;

namespace MijnGolf.Infrastructure.Repositories
{
    public class CourseRepository : IRepository<Course>
    {
        private readonly IList<Course> _courses;

        public CourseRepository()
        {
            _courses = new List<Course>
            {
                new Course(1, "Golfbaan 1", new List<Loop>
                {
                    new Loop(1, 9),
                    new Loop(1, 18),
                }),
                new Course(2, "Golfbaan 2", new List<Loop>
                {
                    new Loop(1, 9),
                    new Loop(1, 18),
                }),
                new Course(3, "Golfbaan 3", new List<Loop>
                {
                    new Loop(1, 9)
                }),
                new Course(4, "Golfbaan 4", new List<Loop>
                {
                    new Loop(1, 18)
                })
            };
        }

        public Course GetItem(ISpecification<Course> specification)
        {
            return _courses.AsQueryable()
                           .FirstOrDefault(specification.ToExpression());
        }

        public IReadOnlyList<Course> GetItems(ISpecification<Course> specification)
        {
            return _courses.AsQueryable()
                           .Where(specification.ToExpression())
                           .ToList()
                           .AsReadOnly();
        }
    }
}