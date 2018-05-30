using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BOL.Models
{
    public class Role
    {
        [ScaffoldColumn(false)]
        public int RoleId { get; set; }

        [Required]
        [DisplayName("Role Name")]
        public string RoleName { get; set; }

        public virtual List<User> Users { get; set; }
    }
}
