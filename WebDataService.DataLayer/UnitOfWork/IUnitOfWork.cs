using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace WebDataService.DataLayer.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        DbContext Context { get; }

        int SaveChange();

    }
}
