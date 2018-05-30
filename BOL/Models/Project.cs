using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BOL.Models
{
    public class Project
    {
        public int ProjectId { get; set; }

        [Required]
        [DisplayName("Project Name")]
        public string ProjectName { get; set; }

        [Required]
        [DisplayName("Description")]
        [UIHint("MultilineText")]
        public string Description { get; set; }

        public bool IsArchived { get; set; }

        public virtual List<Task> Tasks { get; set; }

        public virtual List<Subscribe> Subscribes { get; set; }
    }
}
