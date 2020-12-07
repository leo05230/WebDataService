using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace WebDataService.DataLayer.Repositorys
{
    public interface IRepository<TEntity>
   where TEntity : class
    {
        void Create(TEntity instance);
        void Create(List<TEntity> instance);

        void Update(TEntity instance);

        void Delete(TEntity instance);
        TEntity Get(Expression<Func<TEntity, bool>> predicate);
        IQueryable<TEntity> GetAll();
    }
}
