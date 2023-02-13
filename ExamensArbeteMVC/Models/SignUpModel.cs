using System.ComponentModel.DataAnnotations;

namespace ExamensArbeteMVC.Models
{
    public class SignUpModel
    {
        [Required (ErrorMessage = "Write youe Email, please ")]
        [EmailAddress(ErrorMessage ="Please enter a valid email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Choose a strong password, please ")]
        [Compare("ConfirmPassword", ErrorMessage ="Password dosn't match")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required(ErrorMessage = "Confirm your password, please")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        public string ConfirmPassword { get; set; }

    }
}
