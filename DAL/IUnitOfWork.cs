using System;
using System.Collections.Generic;
using System.Text;
using BOL;
using Microsoft.EntityFrameworkCore;

namespace DAL
{
    public interface IUnitOfWork : IDisposable
    {
        DbContext Context { get; }

        void Commit();
    }
}
