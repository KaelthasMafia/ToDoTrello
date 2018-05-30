using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BOL.Models
{
    public class SubStatus
    {
        [UIHint("HiddenInput")]
        public int SubStatusId { get; set; }

        [Required]
        [DisplayName("Status")]
        public string SubStatusName { get; set; }

        public virtual List<Subscribe> Subscribes { get; set; }
    }
}
