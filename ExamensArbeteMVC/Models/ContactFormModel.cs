using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;
using Xunit;

namespace ExamensArbeteMVC.Models
{
    public class ContactFormModel
    {
        //[System.ComponentModel.DataAnnotations.Required(ErrorMessage="Please enter your name")]
        public string? Name { get; set; }
       
        public string? AfterName { get; set; }
        
        public string? Adress { get; set; }
       
        [EmailAddress]
        public string? Email { get; set; }
        
        public string? Message { get; set; }
        public DateTime SendAt { get; set; }
        public DateTime UtcNow { get; internal set; }
    }
}
