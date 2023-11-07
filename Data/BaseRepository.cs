using BhsChallenge.Interfaces;
using BhsChallenge.Models;
using Microsoft.EntityFrameworkCore;

namespace BhsChallenge.Data
{
    public class BaseRepository<T> : IBaseRepository<T> where T : Base
    {
        private readonly ProductDbContext _productDbContext;

        public BaseRepository(ProductDbContext productDbContext)
        {
            _productDbContext = productDbContext;
        }

        public virtual async Task<List<T>> GetAsync()
        {
            return await _productDbContext.Set<T>()
                             .ToListAsync();
        }

        public virtual async Task<int> CountAsync()
        {
            return await _productDbContext.Set<T>().CountAsync();
        }

        public virtual async Task<T> CreateAsync(T entity)
        {
            await _productDbContext.Set<T>().AddAsync(entity);
            await _productDbContext.SaveChangesAsync();
            return entity;
        }

        public virtual async Task<T> UpdateAsync(T entity)
        {
            _productDbContext.Set<T>().Update(entity);
            await _productDbContext.SaveChangesAsync();
            return entity;
        }

        public virtual async Task<bool> DeleteAsync(int id)
        {
            var entity = await _productDbContext.Set<T>().FindAsync(id);
            if (entity == null)
            {
                return false;
            }

            _productDbContext.Set<T>().Remove(entity);
            await _productDbContext.SaveChangesAsync();
            return true;
        }
    }
}
