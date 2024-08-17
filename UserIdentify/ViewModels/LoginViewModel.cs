using System.ComponentModel.DataAnnotations;

namespace UserIdentify.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage ="Username is Required")]
        public string? Username { get; set; }
        [Required(ErrorMessage ="Password is Required")]
        [DataType(DataType.Password)]
        public string? Password { get; set; }
        [Display(Name="Remember Me")]
        public bool RememberMe { get; set; }



    }
}
