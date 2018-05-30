using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BOL.Models
{
    public class Priority
    {
        [UIHint("HiddenInput")]
        public int PriorityId { get; set; }

        [Required]
        [DisplayName("Priority")]
        public string PriorityName { get; set; }

        public virtual List<Task> Tasks { get; set; }
    }
}
