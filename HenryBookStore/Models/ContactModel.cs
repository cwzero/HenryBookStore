using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HenryBookStore.Models
{
    public class ContactModel
    {
        [Required]
        [Display(Name="First Name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Email Address")]
        public string Email { get; set; }

        [Required]
        [EmailAddress]
        [Compare("Email")]
        [Display(Name = "Confirm Email Address")]
        public string ConfirmEmail { get; set; }

        [Required]
        public BRANCH Location { get; set; }

        [Required]
        public string Comments { get; set; }
    }
}