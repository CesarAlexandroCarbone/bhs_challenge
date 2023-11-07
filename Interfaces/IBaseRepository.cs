using BhsChallenge.Models;

namespace BhsChallenge.Interfaces
{
    public interface IBaseRepository<T> where T : Base
    {
        Task<List<T>> GetAsync();
        Task<int> CountAsync();
        Task<T> CreateAsync(T entity);
        Task<T> UpdateAsync(T entity);
        Task<bool> DeleteAsync(int id);
    }
}
