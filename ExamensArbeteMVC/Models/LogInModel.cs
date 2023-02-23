using System.ComponentModel.DataAnnotations;
namespace ExamensArbeteMVC.Models
{
    public class LogInModel
    {

        [Required(ErrorMessage = "Write youe Email, please ")]
        [RegularExpression("^[a-z0-9._\\.-]+@([a-z0-9-]+\\.)+[a-z]{2,3}$", ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }


        [Required(ErrorMessage = "Choose a password, please ")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Display(Name ="Remember me")]
        public bool RememberMe { get; set; }
    }
}
