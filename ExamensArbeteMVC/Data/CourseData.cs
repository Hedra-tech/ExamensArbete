using ExamensArbeteMVC.Models;
using ExamensArbeteMVC.Controllers;
using System.Linq;

namespace ExamensArbeteMVC.Data
{
    public class CourseData
    {
        public List<CourseModel> GetAllCourses()
        {
            return DataSource();
        }

        public CourseModel GetCourseById(int id)
        {
            return DataSource().Where(x => x.Id == id).FirstOrDefault();

        }
        public CourseModel SearchCourses (string title)
        {
            return DataSource().Where(x => x.Title.Contains(title)).FirstOrDefault();
        }


        private List<CourseModel> DataSource()
        {
            return new List<CourseModel>()
            {
                new CourseModel() { Id = 1, Title = "Javascript",description="", Teacher = "Marcus Lund",price="499$", startDate="2023-05-22" },
                new CourseModel() { Id = 2, Title = "C#",description="", Teacher = "Fredrik Johan",price="249$", startDate="2023-05-08" },
                new CourseModel() { Id = 3, Title = "HTML and CSS",description="", Teacher = "Magnus Pertesson",price="399$", startDate="2023-08-21" },
                new CourseModel() { Id = 4, Title = "Devops",description="", Teacher = "Eva Lundberg" ,price="499$", startDate="2023-06-05"},
                new CourseModel() { Id = 5, Title = "Angular",description="", Teacher = "Amanda Karl" ,price="249$", startDate="2023-06-12"}
            };
        }
    }
}