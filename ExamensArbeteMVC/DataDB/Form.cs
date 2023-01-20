//jag skapar den här class iställt för courseModel för att spara logiken hemligt
namespace ExamensArbeteMVC.DataDB
{
    public class Form
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? AfterName { get; set; }
        public string? Adress { get; set; }
        public string? Email { get; set; }
        public string? Message { get; set; }
    }
}
