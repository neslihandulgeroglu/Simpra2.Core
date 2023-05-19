﻿using System.Linq.Expressions;

namespace APIProject.Core.Repository
{
    public interface IGeneraciRepository<T>where T:class
    {
        Task<T> GetByIdAsync(int id);
        IQueryable<T> GetAll();
        IQueryable<T> Where(Expression<Func<T,bool>>expression);
        Task<bool>AnyAsync(Expression<Func<T,bool>>expression);
        Task AddAsync(T entity);
        Task AddRangeAsync(IEnumerable<T> entities);    
        void Update(T entity);
        
        void Remove(T entity);
        void RemmoveRange(IEnumerable<T> entities);

    }
}
