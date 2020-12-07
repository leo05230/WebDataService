using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using WebDataService.DataLayer.UnitOfWork;

namespace WebDataService.DataLayer.Repositorys
{
    public class Repository<TEntity> : IRepository<TEntity>
         where TEntity : class
    {

        public IUnitOfWork _UnitOfWork { get; set; }

        private DbContext Context { get; set; }

        private DbSet<TEntity> DbSet { get; set; }

        public Repository(IUnitOfWork unitofwork)
        {
            this._UnitOfWork = unitofwork;
            this.Context = unitofwork.Context;
            this.DbSet = this.Context.Set<TEntity>();
        }

        /// <summary>
        /// Gets the specified predicate.
        /// </summary>
        /// <param name="predicate">The predicate.</param>
        /// <returns></returns>
        public TEntity Get(Expression<Func<TEntity, bool>> predicate)
        {
            return this.DbSet.FirstOrDefault(predicate);
        }
        /// <summary>
        /// Creates the specified instance.
        /// </summary>
        /// <param name="instance">The instance.</param>
        /// <exception cref="System.ArgumentNullException">instance</exception>
        public void Create(TEntity instance)
        {
            if (instance == null)
            {
                throw new ArgumentNullException("instance");
            }

            this.DbSet.Add(instance);
        }

        /// <summary>
        /// Updates the specified instance.
        /// </summary>
        /// <param name="instance">The instance.</param>
        /// <exception cref="System.NotImplementedException"></exception>
        public void Update(TEntity instance)
        {
            if (instance == null)
            {
                throw new ArgumentNullException("instance");
            }

            this.Context.Entry(instance).State = EntityState.Modified;
        }

        /// <summary>
        /// Deletes the specified instance.
        /// </summary>
        /// <param name="instance">The instance.</param>
        /// <exception cref="System.NotImplementedException"></exception>
        public void Delete(TEntity instance)
        {
            if (instance == null)
            {
                throw new ArgumentNullException("instance");
            }

            this.Context.Entry(instance).State = EntityState.Deleted;
        }

        /// <summary>
        /// Gets all.
        /// </summary>
        /// <returns></returns>
        public IQueryable<TEntity> GetAll()
        {
            return DbSet;
        }

        public void Create(List<TEntity> instance)
        {
            if (instance == null)
            {
                throw new ArgumentNullException("instance");
            }
            foreach (var item in instance)
            {
                this.DbSet.Add(item);
            }
        }
    }
}
