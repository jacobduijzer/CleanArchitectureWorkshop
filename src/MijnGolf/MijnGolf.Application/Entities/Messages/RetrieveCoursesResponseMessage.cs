using System.Collections.Generic;
using MijnGolf.Domain.Entities;

namespace MijnGolf.Application.Entities.Messages
{
    public class RetrieveCoursesResponseMessage
    {
        public IReadOnlyList<Course> Courses { get; }

        public RetrieveCoursesResponseMessage(IReadOnlyList<Course> courses)
        {
            Courses = courses;
        }
    }
}
