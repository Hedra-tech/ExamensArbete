using System.ComponentModel.DataAnnotations;

namespace ExamensArbeteMVC.Models
{
    public class SignUpModel
    {
        [Required (ErrorMessage = "Write youe Email, please ")]
        [RegularExpression("^[a-z0-9._\\.-]+@([a-z0-9-]+\\.)+[a-z]{2,3}$", ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Choose a password, please ")]
        [Compare("ConfirmPassword", ErrorMessage ="Password dosn't match")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required(ErrorMessage = "Confirm your password, please")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        public string ConfirmPassword { get; set; }

    }
}
