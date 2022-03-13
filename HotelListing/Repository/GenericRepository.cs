using HotelListing.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace HotelListing.Repository
{
    public class GenericRepository<T> : IGenericRepositorycs<T> where T : class
    {
        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void DeleteRange(IEnumerable<T> entities)
        {
            throw new NotImplementedException();
        }

        public Task<T> Get(Expression<Func<T, bool>> expression = null, List<string> includes = null)
        {
            throw new NotImplementedException();
        }

        public Task<IList<T>> GetAll(Expression<Func<T, bool>> expression, Func<IQueryable<T>, IOrderedEnumerable<T>> orderBy = null, List<string> includes = null)
        {
            throw new NotImplementedException();
        }

        public Task<T> Insert(T entity)
        {
            throw new NotImplementedException();
        }

        public Task<T> InsertRange(IEnumerable<T> entities)
        {
            throw new NotImplementedException();
        }

        public void Update(T Entity)
        {
            throw new NotImplementedException();
        }
    }
}
