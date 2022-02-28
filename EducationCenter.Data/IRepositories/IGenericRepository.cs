using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace EducationCenter.Data.IRepositories
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T> CreateAsync(T entity);
        Task<T> GetAsync(Expression<Func<T, bool>> predicate);
        Task<IQueryable<T>> GetAllAsync(Expression<Func<T, bool>> predicate = null);
        Task<T> UpdateAsync(T entity);
        Task<bool> DeleteAsync(Expression<Func<T, bool>> predicate);
    }
}
