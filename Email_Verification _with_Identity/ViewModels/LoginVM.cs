using System.ComponentModel.DataAnnotations;

namespace Email_Verification__with_Identity.ViewModels
{
    public class LoginVM
    {
        [Key]
        public int Id { get; set; }

        [EmailAddress]
        [Required(ErrorMessage = "Please Enter Email")]
        public string Email { get; set; } = default!;
        [Required(ErrorMessage = "Please Enter Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; } = default!;
        [Display(Name ="Remember Me")]

        public bool RememberMe { get; set;}
    }
}
