using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using MijnGolf.Application.Entities.Messages;

namespace MijnGolf.Application.UseCases
{
    public class GetAllCoursesInteractor : IRequestHandler<RetrieveCoursesRequestMessage, RetrieveCoursesResponseMessage>
    {
        // TODO: Add dependency to repository
        public GetAllCoursesInteractor()
        {
        }

        // TODO: Implement handler
        public async Task<RetrieveCoursesResponseMessage> Handle(RetrieveCoursesRequestMessage request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
