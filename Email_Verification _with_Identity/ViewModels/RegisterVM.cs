using System.ComponentModel.DataAnnotations;

namespace Email_Verification__with_Identity.ViewModels
{
    public class RegisterVM
    {
        [Key]
        public int Id { get; set; }

        [EmailAddress]
        [Required(ErrorMessage ="Please Enter Email")]
        public string Email { get; set; } = default!;
        [Required(ErrorMessage = "Please Enter Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; } =default!;
        [Display(Name = "Confirm Password")]
        [Required(ErrorMessage = "Please Enter Confirm Password")]
        [Compare("Password", ErrorMessage = "Password and Confirm Password are not Matched.")]
        public string ConfirmPassword { get; set; } = default!;
    }
}
