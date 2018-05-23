using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoTrello.Models
{
    public class RegisterModel
    {
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Please, enter your Email!")]
        public string Email { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Please, enter your Password!")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "This field must match the password!")]
        public string ComparePassword { get; set; }

        [Required(ErrorMessage = "Please, enter your First Name!")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please, enter your Last Name!")]
        public string LastName { get; set; }
    }
}
