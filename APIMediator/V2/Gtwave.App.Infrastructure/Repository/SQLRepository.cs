using Gtwave.App.Application.Common.Interface;
using Gtwave.App.Domain.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Gtwave.App.Infrastructure.Repository
{
    public class SQLRepository<T> : IRepository<T>
    {
        Task IRepository<T>.DeleteAsync(string entityId, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        Task<List<T>> IRepository<T>.FindAsync(Expression<Func<T, bool>> where, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        Task<List<T>> IRepository<T>.FindAsync(Expression<Func<T, bool>> where, int limit, int offset, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        Task<IList<T>> IRepository<T>.FindAsync(Expression<Func<T, bool>> where, string sortBy, int limit, int offset, bool ascending, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        Task<QueryStatisticListOfT<T>> IRepository<T>.FindAsyncStatistic(Expression<Func<T, bool>> where, int limit, int offset, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        Task<T> IRepository<T>.FindOneAsync(Expression<Func<T, bool>> where, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        Task<T> IRepository<T>.FirstOrDefaultAsync(Expression<Func<T, bool>> where, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        Task<long> IRepository<T>.GetNextSequentialNumberAsync(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        Task IRepository<T>.SaveAsync(T entity, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
