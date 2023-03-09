using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;
using RequiredAttribute = System.ComponentModel.DataAnnotations.RequiredAttribute;

namespace ExamensArbeteMVC.Models
{
    public class ContactFormModel
    {

        [Required(ErrorMessage = "Please enter your name")]
        [StringLength(25, MinimumLength = 2)]

        public string? Name { get; set; }
        [Required(ErrorMessage = "Please enter your lastName")]
        [StringLength(25, MinimumLength = 2)]

        public string? AfterName { get; set; }

        [Required]
        [StringLength(25, MinimumLength = 2)]

        public string? Adress { get; set; }

        [Required(ErrorMessage = "Please enter your email")]
        [RegularExpression("^[a-z0-9._\\.-]+@([a-z0-9-]+\\.)+[a-z]{2,3}$", ErrorMessage = "Invalid Email Address")]
        public string? Email { get; set; }

        [Required]
        [StringLength(1000, MinimumLength = 5)]
        public string? Message { get; set; }

        //public DateTime SendAt { get; set; }

        //public DateTime UtcNow { get; internal set; }
    }
}
