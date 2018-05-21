using System;
using System.Collections.Generic;
using System.Text;

namespace BOL.Models
{
    public class SubStatus
    {
        public int SubStatusId { get; set; }

        public string SubStatusName { get; set; }

        public virtual List<Subscribe> Subscribes { get; set; }
    }
}
