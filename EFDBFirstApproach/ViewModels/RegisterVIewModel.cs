using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace EFDBFirstApproach.View_Models
{
    public class RegisterVIewModel
    {
        [Required(ErrorMessage = "User Name cannot be blank")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Password cannot be blank")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Confirm Password required")]
        [Compare("Password", ErrorMessage ="Password and confirm password should match")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Email cannot be blank")]
        [EmailAddress(ErrorMessage ="Invalid Email ID")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Email cannot be blank")]
        public string Mobile { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Country { get; set; }


    }
}