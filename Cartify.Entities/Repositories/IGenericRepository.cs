using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Cartify.Entities.Repositories
{
    public interface IGenericRepository<T> where T: class
    {
        IEnumerable<T> GetAll(Expression<Func<T, bool>> predicate, string? includes);

        T Get(Expression<Func<T, bool>> predicate, string? include);

        void Add(T entity);
        void Remove(T entity);

        void RemoveRange(IEnumerable<T> entities);
    }
}
