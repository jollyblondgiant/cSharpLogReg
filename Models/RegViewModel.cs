
using System.ComponentModel.DataAnnotations;

namespace LoginReg.Models
{
    public class RegViewModel
    {
        [Required(ErrorMessage = "What's your name, hun?")]
        [MinLength(2, ErrorMessage="Now C'mon, that ain't a real name")]
        [Display(Name="First Name:")]
        public string FirstName {get;set;}

        [Required(ErrorMessage = "I don't even know your last name...")]
        [MinLength(2, ErrorMessage="Now C'mon, that ain't a real name")]
        [Display(Name="Last Name: ")]
        public string LastName {get;set;}
        
        [Required (ErrorMessage = "How am I supposed to send you electronic mail?")]
        [EmailAddress(ErrorMessage="That ain't a real email address")]
        [Display(Name="Email Address:")]
        [DataType(DataType.EmailAddress)]
        public string Email{get;set;}

        [Required(ErrorMessage="What's yer safe word, sweetie?")]
        [MinLength(8, ErrorMessage="No PIck a better one, I'll forget that one")]
        [Display(Name="Password:")]
        [DataType(DataType.Password)]
        public string Password{get;set;}

        [Required(ErrorMessage="Can you repeat that?")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage="That ain't what you said, tho")]
        [Display(Name="Confirm Password:")]
        public string ConfirmPassword{get;set;}

        
    }
}