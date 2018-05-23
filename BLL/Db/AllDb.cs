using System;
using System.Collections.Generic;
using System.Text;
using BOL;

namespace BLL.Db
{
    public class AllDb
    {
        public AllDb(ToDoTrelloContext context)
        {
            PriorityDb = new PriorityDb(context);
            ProjectDb = new ProjectDb(context);
            RoleDb = new RoleDb(context);
            SubscribeDb = new SubscribeDb(context);
            SubStatusDb = new SubStatusDb(context);
            TaskDb = new TaskDb(context);
            UserDb = new UserDb(context);
        }

        public PriorityDb PriorityDb { get; set; }

        public ProjectDb ProjectDb { get; set; }

        public RoleDb RoleDb { get; set; }

        public SubscribeDb SubscribeDb { get; set; }

        public SubStatusDb SubStatusDb { get; set; }

        public TaskDb TaskDb { get; set; }

        public UserDb UserDb { get; set; }
    }
}
