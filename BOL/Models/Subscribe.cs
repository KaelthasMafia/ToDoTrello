using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BOL.Models
{
    public class Subscribe
    {
        [ScaffoldColumn(false)]
        public int SubscribeId { get; set; }

        public int UserId { get; set; }

        public int ProjectId { get; set; }

        [ScaffoldColumn(false)]
        public bool IsUserOwner { get; set; }

        public virtual User User { get; set; }

        public virtual Project Project { get; set; }
    }
}
