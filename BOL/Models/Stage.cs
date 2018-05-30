using System;
using System.Collections.Generic;
using System.Text;

namespace BOL.Models
{
    public class Stage
    {
        public int StageId { get; set; }

        public string StageName { get; set; }

        public int ProjectId { get; set; }

        public virtual Project Project { get; set; }

        public virtual List<Task> Tasks { get; set; }

    }
}
