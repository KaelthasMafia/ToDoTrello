using System;
using System.Collections.Generic;
using System.Text;
using BOL;
using Microsoft.EntityFrameworkCore;

namespace DAL
{
    public class UnitOfWork
    {
        public ToDoTrelloContext Context { get; }

        public UnitOfWork(ToDoTrelloContext context)
        {
            Context = context;
        }
        public void Commit()
        {
            Context.SaveChanges();
        }

        public void Dispose()
        {
            Context.Dispose();
        }
    }
}
