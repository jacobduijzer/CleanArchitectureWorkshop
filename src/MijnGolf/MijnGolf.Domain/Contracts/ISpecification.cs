using System;
using System.Linq.Expressions;

namespace MijnGolf.Domain.Contracts
{
    public interface ISpecification<T>
    {
        Expression<Func<T, bool>> ToExpression();

        bool IsSatisfiedBy(T entity);

        ISpecification<T> And(ISpecification<T> specification);

        ISpecification<T> Or(ISpecification<T> specification);
    }
}
