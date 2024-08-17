using System.ComponentModel.DataAnnotations;

namespace UserIdentify.ViewModels
{
    public class RegisterViewmodel
    {
        [Required]
        public string? Name {  get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string? Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string? Password { get; set; }
        [Compare("Password",ErrorMessage ="Password doesnot match")]
        [Display(Name="Confirm Password")]
        [DataType(DataType.Password)]
        public string? ConfirmedPassword { get; set;}
        [DataType(DataType.MultilineText)]
        public string? Address { get; set; }


    }
}
