using System.Collections.Generic;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Business.Repositories
{
    public interface IRepository<T> where T : class
    {
        List<T> GetAll();
        List<T> GetAll(Expression<Func<T, bool>> expression);
        Task<IEnumerable<T>> GetAllAsync();
        Task<IEnumerable<T>> GetAllAsync(Expression<Func<T, bool>> expression);
        T Get(Expression<Func<T, bool>> expression);
        Task<T> GetAsync(Expression<Func<T, bool>> expression);
        T Find(int id);
        Task<T> FindAsync(int id);

        int Add(T entity);
        Task AddAsync(T entity);

        int Update(T entity);
        Task<int> UpdateAsync(T entity);

        int Delete(T entity);
        Task<int> DeleteAsync(T entity);

        int SaveChanges();
        Task<int> SaveChangesAsync();

        List<T> GetAllInclude(params Expression<Func<T, object>>[] tables);
        Task<List<T>> GetAllIncludeAsync(params Expression<Func<T, object>>[] tables);

        IQueryable<T> GetAllIncludeQueryable(params Expression<Func<T, object>>[] tables);
        DbSet<T> GetDb();


        Task<List<T>> GetIdAllIncludeFilterAsync(Expression<Func<T, bool>> expression, params Expression<Func<T, object>>[] tables);
    }
}
