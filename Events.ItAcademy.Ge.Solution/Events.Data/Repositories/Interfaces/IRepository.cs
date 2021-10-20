using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Events.Data.Repositories.Interfaces
{
    public interface IRepository<T> where T : class
    {
        IQueryable Data { get; }

        T GetSingleById(object id);

        Task<T> GetSingleByIdAsync(object id);

        T FirstOrDefault(Expression<Func<T, bool>> whereCondition);

        Task<T> FirstOrDefaultAsync(Expression<Func<T, bool>> whereCondition);

        bool Any(Expression<Func<T, bool>> whereCondition);

        Task<bool> AnyAsync(Expression<Func<T, bool>> whereCondition);

        IQueryable<T> Where(Expression<Func<T, bool>> whereCondition);

        void Add(T entity);

        Task AddAsync(T entity);

        void Delete(T entity);

        long Count(Expression<Func<T, bool>> whereCondition);

        Task<long> CountAsync(Expression<Func<T, bool>> whereCondition);

        long Count();

        Task<long> CountAsync();
    }
}
