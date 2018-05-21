using System;
using System.Collections.Generic;
using System.Text;

namespace BOL.Models
{
    public class Task
    {
        public int TaskId { get; set; }

        public string TaskName { get; set; }

        public string Description { get; set; }

        public int PriorityId { get; set; }

        public int ProjectId { get; set; }

        public virtual Priority Priority { get; set; }

        public virtual Project Project { get; set; }
    }
}
