using System;
using System.Collections.Generic;
using System.Text;

namespace BOL.Models
{
    public class Priority
    {
        public int PriorityId { get; set; }

        public string PriorityName { get; set; }

        public virtual List<Task> Tasks { get; set; }
    }
}
