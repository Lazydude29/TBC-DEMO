using Events.Data.Context;
using Events.Data.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events.Data.Repositories.Implementations
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly EventsContext _context;

        private readonly DbSet<T> _dbSet;

        public Repository(EventsContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }

        public IQueryable Data
        {
            get
            {
                return _dbSet;
            }
        }

        public void Add(T entity)
        {
            _dbSet.Add(entity);
        }

        public async Task AddAsync(T entity)
        {
            await _dbSet.AddAsync(entity);
        }

        public bool Any(System.Linq.Expressions.Expression<Func<T, bool>> whereCondition)
        {
            return _dbSet.Any(whereCondition);
        }

        public async Task<bool> AnyAsync(System.Linq.Expressions.Expression<Func<T, bool>> whereCondition)
        {
            return await _dbSet.AnyAsync(whereCondition);
        }

        public long Count(System.Linq.Expressions.Expression<Func<T, bool>> whereCondition)
        {
            return _dbSet.Count(whereCondition);
        }

        public long Count()
        {
            return _dbSet.LongCount();
        }

        public async Task<long> CountAsync(System.Linq.Expressions.Expression<Func<T, bool>> whereCondition)
        {
            return await _dbSet.CountAsync(whereCondition);
        }

        public async Task<long> CountAsync()
        {
            return await _dbSet.LongCountAsync();
        }

        public void Delete(T entity)
        {
            _dbSet.Remove(entity);
        }

        public T FirstOrDefault(System.Linq.Expressions.Expression<Func<T, bool>> whereCondition)
        {
            return _dbSet.FirstOrDefault(whereCondition);
        }

        public async Task<T> FirstOrDefaultAsync(System.Linq.Expressions.Expression<Func<T, bool>> whereCondition)
        {
            return await _dbSet.FirstOrDefaultAsync(whereCondition);
        }

        public T GetSingleById(object id)
        {
            return _dbSet.Find(id);
        }

        public async Task<T> GetSingleByIdAsync(object id)
        {
            return await _dbSet.FindAsync(id);
        }

        public IQueryable<T> Where(System.Linq.Expressions.Expression<Func<T, bool>> whereCondition)
        {
            return _dbSet.Where(whereCondition);
        }
    }
}
