using System;
using System.Collections.Generic;
using System.Text;

namespace BOL.Models
{
    public class Subscribe
    {
        public int SubscribeId { get; set; }

        public int UserId { get; set; }

        public int ProjectId { get; set; }

        public int StatusId { get; set; }

        public bool IsUserOwner { get; set; }

        public virtual User User { get; set; }

        public virtual Project Project { get; set; }

        public virtual SubStatus SubStatus { get; set; }
    }
}
