using BhsChallenge.Interfaces;
using BhsChallenge.Models;

namespace BhsChallenge.Services
{
    public class GenericListService<T> : IGenericListService<T> where T : Base
    {
        private readonly IBaseRepository<T> _baseRepository;

        public GenericListService(IBaseRepository<T> baseRepository)
        {
            _baseRepository = baseRepository;
        }

        public async Task<GenericList<T>> ListAsync()
        {
            return new GenericList<T>(await _baseRepository.GetAsync());
        }
    }
}
