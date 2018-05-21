using System;
using System.Collections.Generic;
using System.Text;

namespace BOL.Models
{
    public class Project
    {
        public int ProjectId { get; set; }

        public string ProjectName { get; set; }

        public string Description { get; set; }

        public bool IsArchived { get; set; }

        public virtual List<Task> Tasks { get; set; }

        public virtual List<Subscribe> Subscribes { get; set; }
    }
}
