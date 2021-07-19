using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using EFDbFirstApproachExample.Models;

namespace EFDbFirstApproachExample.CustomValidations
{
    public class HobbiesValidation : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            User u = (User)value;
            if ((u.Photography && u.Gardening && u.Dance && u.Hiking && u.Painting) || (u.Photography == false && u.Gardening == false && u.Dance == false && u.Hiking == false && u.Painting == false))
            {
                return new ValidationResult(this.ErrorMessage);
            }
            else
            {                
                return ValidationResult.Success;
            }
        }
    }
}