using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace HotelListing.IRepository
{
    public interface IGenericRepository<T> where T : class
    {
        Task<IList<T>> GetAll(
            Expression<Func<T, bool>> expression,
            Func<IQueryable<T>, IOrderedEnumerable<T>> orderBy = null,
            List<string> includes = null);

        Task<T> Get(
            Expression<Func<T, bool>> expression = null,
            List<string> includes = null);

        Task<T> Insert(T entity);
        Task<T> InsertRange(IEnumerable<T> entities);
        Task Delete(int id);
        void DeleteRange(IEnumerable<T> entities);
        void Update(T Entity);

    }
}
