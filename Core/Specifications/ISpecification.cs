using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Core.Specifications
{
    public interface ISpecification<T>
    {
        Expression<Func<T, bool>> Criteria { get; }   // what's the specification/criteria of what we want to get?

        List<Expression<Func<T, object>>> Includes { get; }
    }
}