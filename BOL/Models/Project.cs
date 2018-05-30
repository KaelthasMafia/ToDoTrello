using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BOL.Models
{
    public class Project
    {
        [ScaffoldColumn(false)]
        public int ProjectId { get; set; }

        [Required]
        [DisplayName("Project Name")]
        public string ProjectName { get; set; }

        [Required]
        [DisplayName("Description")]
        [UIHint("MultilineText")]
        public string Description { get; set; }

        [UIHint("HiddenInput")]
        public bool IsArchived { get; set; }

        public virtual List<Subscribe> Subscribes { get; set; }

        public virtual List<Stage> Stages { get; set; }
    }
}
