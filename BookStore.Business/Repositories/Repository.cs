using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using BookStore.Entities.Abstract;
using BookStore.Data;

namespace BookStore.Business.Repositories
{
    public class Repository<T> : IRepository<T> where T : class, IBaseEntity, new()
    {
        internal readonly BookStoreDbContext _databaseContext;
        DbSet<T> _dbSet;
        public Repository(BookStoreDbContext databaseContext)
        {
            _databaseContext = databaseContext;
            _dbSet = _databaseContext.Set<T>();
        }


        public List<T> GetAll()
        {
            return _dbSet.ToList();
        }
        public List<T> GetAll(Expression<Func<T, bool>> expression)
        {
            return _dbSet.Where(expression).ToList();
        }
        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }
        public async Task<IEnumerable<T>> GetAllAsync(Expression<Func<T, bool>> expression)
        {
            return await _dbSet.Where(expression).ToListAsync();
        }

        public T Get(Expression<Func<T, bool>> expression)
        {
            return _dbSet.FirstOrDefault(expression)!;
        }
        public async Task<T> GetAsync(Expression<Func<T, bool>> expression)
        {
            return await _dbSet.FirstOrDefaultAsync(expression) ?? new T();
        }

        public T Find(int id)
        {
            return _dbSet.Find(id)!;
        }
        public async Task<T> FindAsync(int id)
        {
            return await _dbSet.FindAsync(id) ?? new T();
        }

        public int Add(T entity)
        {
            _dbSet.Add(entity);
            return SaveChanges();
        }
        public async Task AddAsync(T entity)
        {
            await _dbSet.AddAsync(entity);
        }

        public int Update(T entity)
        {
            _databaseContext.Update(entity);
            return SaveChanges();
        }
        public async Task<int> UpdateAsync(T entity)
        {
            _databaseContext.Update(entity);
            return await SaveChangesAsync();
        }

        public int Delete(T entity)
        {
            _dbSet.Remove(entity);
            return SaveChanges();
        }
        public async Task<int> DeleteAsync(T entity)
        {
            _dbSet.Remove(entity);
            return await SaveChangesAsync();
        }

        public int SaveChanges()
        {
            return _databaseContext.SaveChanges();
        }
        public async Task<int> SaveChangesAsync()
        {
            return await _databaseContext.SaveChangesAsync();
        }


        public List<T> GetAllInclude(params Expression<Func<T, object>>[] tables)
        {
            IQueryable<T> db = _dbSet;
            foreach (var table in tables)
            {
                db = db.Include(table);
            }

            return db.ToList(); ;
        }
        public async Task<List<T>> GetAllIncludeAsync(params Expression<Func<T, object>>[] tables)
        {
            IQueryable<T> db = _dbSet;
            foreach (var table in tables)
            {
                db = db.Include(table);
            }

            return await db.ToListAsync();
        }


        public async Task<List<T>> GetIdAllIncludeFilterAsync(Expression<Func<T, bool>> expression, params Expression<Func<T, object>>[] tables)
        {
            IQueryable<T> db = _dbSet;
            foreach (var table in tables)
            {
                db = db.Include(table);
            }

            return await db.Where(expression).ToListAsync();
        }







        public IQueryable<T> GetAllIncludeQueryable(params Expression<Func<T, object>>[] tables)
        {
            IQueryable<T> db = _dbSet;
            foreach (var table in tables)
            {
                db = db.Include(table);
            }

            return db;
        }

        public DbSet<T> GetDb()
        {
            return _dbSet;
        }


#nullable disable
#nullable restore

    }
}
