using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace EFDBFirstApproach.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "User Name is requried")]
        public string Username { get; set; }
        [Required(ErrorMessage ="Password can't be blank")]
        public string Password { get; set; }

    }
}