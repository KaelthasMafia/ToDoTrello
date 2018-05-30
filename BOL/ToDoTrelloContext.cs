using System;
using System.Collections.Generic;
using System.Text;
using BOL.Models;
using Microsoft.EntityFrameworkCore;

namespace BOL
{
    public class ToDoTrelloContext : DbContext
    {
        public ToDoTrelloContext(DbContextOptions<ToDoTrelloContext> options)
            : base(options) { }

        public DbSet<User> Users { get; set; }

        public DbSet<Task> Tasks { get; set; }

        public DbSet<Work> Works { get; set; }

        public DbSet<Stage> Stages { get; set; }

        public DbSet<Subscribe> Subscribes { get; set; }

        public DbSet<Role> Roles { get; set; }

        public DbSet<Project> Projects { get; set; }

        public  DbSet<Priority> Priorities { get; set; }
    }
}
