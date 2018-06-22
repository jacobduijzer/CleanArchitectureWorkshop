using MediatR;

namespace MijnGolf.Application.Entities.Messages
{
    public class RetrieveCoursesRequestMessage : IRequest<RetrieveCoursesResponseMessage>
    {
        public RetrieveCoursesRequestMessage()
        {
        }
    }
}
