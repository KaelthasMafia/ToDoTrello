using System;
using System.Collections.Generic;
using System.Text;
using BOL;
using Microsoft.EntityFrameworkCore;

namespace DAL
{
    public interface IUnitOfWork : IDisposable
    {
        ToDoTrelloContext Context { get; }

        void Commit();
    }
}
