using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MVCFIZZBUZZ.Models.ViewModel
{
    public class FizzBuzzViewModel
    {
        [Required(ErrorMessage = "Please enter number")]
        [Range(1, 1000, ErrorMessage = "Enter number between 1 to 1000")]
        public virtual int UserInputId { get; set; }
    }
}