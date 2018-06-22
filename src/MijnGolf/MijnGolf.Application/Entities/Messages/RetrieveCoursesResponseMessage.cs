using System.Collections.Generic;
using MijnGolf.Domain.Entities;

namespace MijnGolf.Application.Entities.Messages
{
    public class RetrieveCoursesResponseMessage
    {
        public RetrieveCoursesResponseMessage(IReadOnlyList<Course> courses)
        {
        }
    }
}
