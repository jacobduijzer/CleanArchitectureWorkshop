using System.Collections.Generic;

namespace MijnGolf.Domain.Contracts
{
    public interface IRepository<T>
    {
        IReadOnlyList<T> GetItems(ISpecification<T> specification);

        T GetItem(ISpecification<T> specification);
    }
}