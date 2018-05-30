using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BOL.Models
{
    public class Stage
    {
        [ScaffoldColumn(false)]
        public int StageId { get; set; }

        [Required]
        [DisplayName("Stage")]
        public string StageName { get; set; }

        public int ProjectId { get; set; }

        public virtual Project Project { get; set; }

        public virtual List<Task> Tasks { get; set; }

    }
}
