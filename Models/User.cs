using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using EFDbFirstApproachExample.CustomValidations;

namespace EFDbFirstApproachExample.Models
{
    [HobbiesValidation(ErrorMessage = "You can choose from 1 to 4 hobbies, not less, not more.")]
    public class User
    {     

        [Key]        
        public long UserID { get; set; }

        [Display(Name = "First Name")]
        [Required(ErrorMessage = "Must provide a first name")]
        [RegularExpression(@"^[A-Za-z ]*$", ErrorMessage = "Alphabets only")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Must provide a name")]
        [RegularExpression(@"^[A-Za-z ]*$", ErrorMessage = "Alphabets only")]
        public string LastName { get; set;}

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Not a valid email address")]
        public string Email { get; set; }

        [RegularExpression(@"/^(\+\d{1,3}[- ]?)?\d{10}$/", ErrorMessage = "Not a valid mobile format")]
        public string Mobile { get; set; }

        public bool Photography { get; set; }
        public bool Gardening { get; set; }
        public bool Dance { get; set; }
        public bool Hiking { get; set; }
        public bool Painting { get; set; }
    }
}