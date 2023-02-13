//jag skapar den här class iställt för courseModel för att spara logiken hemligt
using ExamensArbeteMVC.RepositoryData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace ExamensArbeteMVC.DBcontext
{
    public class Form
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? AfterName { get; set; }
        public string? Adress { get; set; }
        public string? Email { get; set; }
        public string? Message { get; set; }
        public DateTime SendAt { get; set; }
    }
}
