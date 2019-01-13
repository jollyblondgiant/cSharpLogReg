
using System.ComponentModel.DataAnnotations;

namespace LoginReg.Models
{
    public class LogViewModel
    {
        [Required(ErrorMessage="Need that email, traveler")]
        [EmailAddress(ErrorMessage="No funny business")]
        [DataType(DataType.EmailAddress)]
        [Display(Name="Login Email: ")]
        public string Email {get;set;}

        [Required(ErrorMessage="What's your safe word?")]
        [MinLength(8, ErrorMessage="Passwords must be at least 8 characters long")]
        [DataType(DataType.Password)]
        [Display(Name="Login Password: ")]
        public string Password{get;set;}
    }
}