using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BOL.Models
{
    public class Subscribe
    {
        [UIHint("HiddenInput")]
        public int SubscribeId { get; set; }

        public int UserId { get; set; }

        public int ProjectId { get; set; }

        public bool IsUserOwner { get; set; }

        public virtual User User { get; set; }

        public virtual Project Project { get; set; }
    }
}
