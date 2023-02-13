using ExamensArbeteMVC.Models;
using ExamensArbeteMVC.Controllers;

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
        public List<CourseModel> SearchCourses (string title, string teacherName)
        {
            return DataSource().Where(x => x.Title.Contains(title) && x.Teacher.Contains(teacherName)).ToList();
        }


        private List<CourseModel> DataSource()
        {
            return new List<CourseModel>()
            {
                new CourseModel() { Id = 1, Title = "Javascript", Teacher = "Marcus" },

                new CourseModel() { Id = 2, Title = "C#", Teacher = "Fredrik" },
                new CourseModel() { Id = 3, Title = "HTML and CSS", Teacher = "Magnus" },
                new CourseModel() { Id = 4, Title = "Devops", Teacher = "Eva" },
                new CourseModel() { Id = 5, Title = "Angular", Teacher = "Amanda" }
            };
        }
    }
}