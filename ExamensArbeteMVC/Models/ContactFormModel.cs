namespace ExamensArbeteMVC.Models
{
    public class ContactFormModel
    {
    
        public string? Name { get; set; }
        public string? AfterName { get; set; }
        public string? Adress { get; set; }
        public string? Email { get; set; }
        public string? Message { get; set; }
        public DateTime SendAt { get; set; }
        public DateTime UtcNow { get; internal set; }
    }
}
