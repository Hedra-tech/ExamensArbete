using ExamensArbeteMVC.Models;
using ExamensArbeteMVC.Controllers;
using System.Linq;
using ExamensArbeteMVC.DBcontext;
using Microsoft.EntityFrameworkCore;

namespace ExamensArbeteMVC.RepositoryData
{
    public class FormData : IFormData
    {
        private readonly StoreContext _context = null;
        public FormData(StoreContext context)
        {
            _context = context;
        }
        public async Task<int> ContactForm(ContactFormModel model)
        {
            var newContact = new Form()
            {
                Name = model.Name,
                AfterName = model.AfterName,
                Adress = model.Adress,
                Email = model.Email,
                Message = model.Message,
                SendAt = model.UtcNow

            };
            await _context.Contacts.AddAsync(newContact);

            await _context.SaveChangesAsync();
            return newContact.Id;

        }

        internal Task GetAllCourses()
        {
            throw new NotImplementedException();
        }


        //private List<CourseModel> DataSource()
        //{
        //    return new List<CourseModel>()
        //    {
        //        new CourseModel() { Id = 1, Title = "Javascript",description="", Teacher = "Marcus Lund",price="499$", startDate="2023-05-22", },
        //        new CourseModel() { Id = 2, Title = "C#",description="", Teacher = "Fredrik Johan",price="249$", startDate="2023-05-08" },
        //        new CourseModel() { Id = 3, Title = "HTML and CSS",description="", Teacher = "Magnus Pertesson",price="399$", startDate="2023-08-21" },
        //        new CourseModel() { Id = 4, Title = "Devops",description="", Teacher = "Eva Lundberg" ,price="499$", startDate="2023-06-05"},
        //        new CourseModel() { Id = 5, Title = "Angular",description="", Teacher = "Amanda Karl" ,price="249$", startDate="2023-06-12"}
        //    };
        //}
    }
}