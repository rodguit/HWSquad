using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Gtwave.App.Domain.Models.Entities;

namespace Gtwave.App.Application.Common.Interface
{
    /// <summary>
    /// Handles the database manipulation
    /// </summary>
    /// <typeparam name="T">An object to be stored and handle the filters</typeparam>
    public interface IRepository<T>
    {
        /// <summary>
        /// Find objects from database using where filter
        /// </summary>
        /// <param name="where">The filter to search on database</param>
        /// <param name="cancellationToken">Propagates notification that operations should be canceled.</param>
        /// <exception cref="Domain.Exceptions.DatabaseException">Thrown when there is an issue with the database</exception>
        /// <returns>A list of object found or null</returns>
        Task<List<T>> FindAsync(Expression<Func<T, bool>> where, CancellationToken cancellationToken = default);

        /// <summary>
        /// Find objects from database using where filter
        /// </summary>
        /// <param name="where">The filter to search on database</param>
        /// <param name="limit">limit Number of Records to return</param>
        /// <param name="offset">Numbers of records to skip from the start</param>
        /// <param name="cancellationToken">Propagates notification that operations should be canceled.</param>
        /// <exception cref="Domain.Exceptions.DatabaseException">Thrown when there is an issue with the database</exception>
        /// <returns>A list of object found or null</returns>
        Task<List<T>> FindAsync(Expression<Func<T, bool>> where, int limit, int offset = 0, CancellationToken cancellationToken = default);

        /// <summary>
        /// Find objects from database using where filter with orderby
        /// </summary>
        /// <param name="where">The filter to search on database</param>
        /// <param name="sortBy">The filter to sort on database</param>
        /// <param name="limit">limit Number of Records to return</param>
        /// <param name="offset">Numbers of records to skip from the start</param>
        /// <param name="ascending">Ordenate by ascending or descending</param>
        /// <param name="cancellationToken">Propagates notification that operations should be canceled.</param>
        /// <exception cref="Domain.Exceptions.DatabaseException">Thrown when there is an issue with the database</exception>
        /// <returns>A list of object found or null</returns>
        Task<IList<T>> FindAsync(Expression<Func<T, bool>> where, string sortBy, int limit = 30, int offset = 0, bool ascending = false, CancellationToken cancellationToken = default);

        /// <summary>
        /// Find objects from database using where filter
        /// </summary>
        /// <param name="where">The filter to search on database</param>
        /// <param name="limit">limit Number of Records to return</param>
        /// <param name="offset">Numbers of records to skip from the start</param>
        /// <param name="cancellationToken">Propagates notification that operations should be canceled.</param>
        /// <exception cref="Domain.Exceptions.DatabaseException">Thrown when there is an issue with the database</exception>
        /// <returns>A list of object found or null</returns>
        Task<QueryStatisticListOfT<T>> FindAsyncStatistic(Expression<Func<T, bool>> where, int limit, int offset = 0, CancellationToken cancellationToken = default);

        /// <summary>
        /// Find one object from database using where filter.
        /// This method throws an exception if more than one element satisfies the condition.
        /// </summary>
        /// <param name="where">The filter to search on database</param>
        /// <param name="cancellationToken">Propagates notification that operations should be canceled.</param>
        /// <exception cref="Domain.Exceptions.DatabaseException">Thrown when there is an issue with the database</exception>
        /// <returns>An object found or null</returns>
        Task<T> FindOneAsync(Expression<Func<T, bool>> where, CancellationToken cancellationToken = default);

        /// <summary> 
        /// Asynchronously returns the first element of a sequence from database that satisfies a specified
        /// condition or a default value if no such element is found.   
        /// </summary>
        /// <param name="where">The filter to search on database</param>
        /// <param name="cancellationToken">Propagates notification that operations should be canceled.</param>
        /// <exception cref="Domain.Exceptions.DatabaseException">Thrown when there is an issue with the database</exception>
        /// <returns>An object found or null</returns>
        Task<T> FirstOrDefaultAsync(Expression<Func<T, bool>> where, CancellationToken cancellationToken = default);

        /// <summary>
        /// Create or Update a record on database
        /// </summary>
        /// <param name="entity">Object to created or updated</param>
        /// <param name="cancellationToken">Propagates notification that operations should be canceled.</param>
        /// <exception cref="Domain.Exceptions.DatabaseException">Thrown when there is an issue with the database</exception>
        /// <returns>The created item</returns>
        Task SaveAsync(T entity, CancellationToken cancellationToken = default);

        /// <summary>
        /// Delete a record on database
        /// </summary>
        /// <param name="entityId">EntityId to delete</param>
        /// <param name="cancellationToken">Propagates notification that operations should be canceled.</param>
        /// <exception cref="Domain.Exceptions.DatabaseException">Thrown when there is an issue with the database</exception>
        Task DeleteAsync(string entityId, CancellationToken cancellationToken = default);

        /// <summary>
        /// Generate sequential number from database
        /// </summary>
        /// <param name="cancellationToken">Propagates notification that operations should be canceled.</param>
        /// <exception cref="Domain.Exceptions.DatabaseException">Thrown when there is an issue with the database</exception>
        /// <returns>Long number value</returns>
        Task<long> GetNextSequentialNumberAsync(CancellationToken cancellationToken = default);
    }
}
