using EducationCenter.Data.Contexts;
using EducationCenter.Data.IRepositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace EducationCenter.Data.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        DbContext _dbContext;
        DbSet<T> _dbSet { get; set; }
        public GenericRepository()
        {
            _dbContext = new EduCenterDbContext();
            this._dbSet = _dbContext.Set<T>();
        }
        public async Task<T> CreateAsync(T entity)
        {
            EntityEntry entry = await _dbSet.AddAsync(entity);
            _dbContext.SaveChanges();
            return (T)entry.Entity;
        }

        public async Task<bool> DeleteAsync(Expression<Func<T, bool>> predicate)
        {
            var entity = await _dbSet.FirstOrDefaultAsync(predicate);
            if (entity is null)
                return false;

            _dbSet.Remove(entity);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<IQueryable<T>> GetAllAsync(Expression<Func<T, bool>> predicate = null)
        {
            return predicate is null ? _dbSet : _dbSet.Where(predicate);
        }

        public async Task<T> GetAsync(Expression<Func<T, bool>> predicate)
        {
            return await _dbSet.FirstOrDefaultAsync(predicate);
        }

        public async Task<T> UpdateAsync(T entity)
        {
            var entry = _dbSet.Update(entity);
            await _dbContext.SaveChangesAsync();
            return entry.Entity;
        }
    }
}
