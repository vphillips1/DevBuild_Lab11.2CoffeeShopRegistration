using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeShopRegistrationLab11._2.Models
{
    public class AddUser
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string UserName { get; set; }

        [Required]
        public DateTime Birthday { get; set; }

        [Required]
        [Range(18, 1000, ErrorMessage ="You have to be 18 years or older")]
        public int Age { get; set; }

        [Required]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Please enter a valid email")]
       
        public string Email { get; set; }

        [Required]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Email does not match")]
       
        [Compare("Email")]
        public string EmailConfirmation { get; set; }

        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Entered phone format is not valid. please try again.")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Please Enter your password")]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 8)]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        
        [Required(ErrorMessage ="Confirm your password")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Confirm password does not match")]
        public string PasswordConfirmation{ get; set; }

       


    }
}
