using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using MijnGolf.Application.Entities.Messages;
using MijnGolf.Domain.Contracts;
using MijnGolf.Domain.Entities;
using MijnGolf.Application.Data.Specifications;
using System.Linq;

namespace MijnGolf.Application.UseCases
{
    public class GetAllCoursesInteractor : IRequestHandler<RetrieveCoursesRequestMessage, RetrieveCoursesResponseMessage>
    {   
        public GetAllCoursesInteractor(IRepository<Course> courseRepository)
        {
            _courseREepository = courseRepository;
        }

        public async Task<RetrieveCoursesResponseMessage> Handle(RetrieveCoursesRequestMessage request, CancellationToken cancellationToken)
        {
            var items = _courseREepository.GetItems(new AllCoursesSpecification());
            return new RetrieveCoursesResponseMessage(items);
        }

        private IRepository<Course> _courseREepository;
    }
}
