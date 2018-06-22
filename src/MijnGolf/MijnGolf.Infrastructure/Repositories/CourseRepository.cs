using System.Collections.Generic;
using MijnGolf.Domain.Entities;
using System.Collections;
using System.Linq;

namespace MijnGolf.Infrastructure.Repositories
{
    public class CourseRepository
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

        public IReadOnlyList<Course> GetAll()
        {
            return _courses.ToList()
                           .AsReadOnly();
        }
    }
}