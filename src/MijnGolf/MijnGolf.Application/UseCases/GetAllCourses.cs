using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using MijnGolf.Application.Entities.Messages;

namespace MijnGolf.Application.UseCases
{
    public class GetAllCourses : IRequestHandler<RetrieveCoursesRequestMessage, RetrieveCoursesResponseMessage>
    {
        // TODO: Add dependency to repository
        public GetAllCourses()
        {
        }

        // TODO: Implement handler
        public Task<RetrieveCoursesResponseMessage> Handle(RetrieveCoursesRequestMessage request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
