using System.ComponentModel.DataAnnotations;
namespace ExamensArbeteMVC.Models
{
    public class LogInModel
    {
        [Required(ErrorMessage = "Write youe Email, please ")]
        public string Email { get; set; }


        [Required(ErrorMessage = "Choose a strong password, please ")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Display(Name ="Remember me")]
        public bool RememberMe { get; set; }
    }
}
