using BhsChallenge.Models;

namespace BhsChallenge.Interfaces
{
    public interface IGenericListService<T> where T : Base
    {
        Task<GenericList<T>> ListAsync();
    }
}
