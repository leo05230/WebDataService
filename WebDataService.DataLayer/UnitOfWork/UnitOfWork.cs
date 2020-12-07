using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using WebDataService.Domain.Entities;

namespace WebDataService.DataLayer.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        public DbContext Context { get; }

        public UnitOfWork(DataSetContext context)
        {
            Context = context;
        }
        public int SaveChange()
        {
            try
            {
                return this.Context.SaveChanges();
            }
            catch (System.Data.DataException ex)
            {
                throw new Exception(ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Dispose()
        {
            Context.Dispose();
        }
    }
}
