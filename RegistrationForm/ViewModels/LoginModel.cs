using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace RegistrationForm.ViewModels
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Domain is not specified")]
        public string Domain { get; set; }

        [Required(ErrorMessage = "User is not specified")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Password is not specified")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
