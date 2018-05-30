using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BOL.Models
{
    public class Task
    {
        [UIHint("HiddenInput")]
        public int TaskId { get; set; }

        [Required]
        [DisplayName("Task Name")]
        public string TaskName { get; set; }

        [Required]
        [UIHint("MultilineText")]
        [DisplayName("Description")]
        public string Description { get; set; }

        public int PriorityId { get; set; }

        public int StageId { get; set; }

        public virtual Priority Priority { get; set; }

        public virtual Stage Stage { get; set; }

        public virtual List<Work> Works { get; set; }
    }
}
