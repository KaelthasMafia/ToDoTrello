using System;
using System.Collections.Generic;
using System.Text;

namespace BOL.Models
{
    public class Work
    {
        public int WorkId { get; set; }

        public int UserId { get; set; }

        public int TaskId { get; set; }

        public User User { get; set; }

        public Task Task { get; set; }

        public bool IsUserOwner { get; set; }
    }
}
