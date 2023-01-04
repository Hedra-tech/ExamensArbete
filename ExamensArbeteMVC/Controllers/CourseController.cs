using ExamensArbeteMVC.Data;
using ExamensArbeteMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace ExamensArbeteMVC.Controllers
{
    public class CourseController : Controller
    {
        private readonly CourseData _courseData = null;
            public CourseController()
        {
            _courseData = new CourseData();
        }
        public List<CourseModel> GetAllCourses()
        {
            return _courseData.GetAllCourses();
        }

        public CourseModel GetCourseById(int id)
        {
            return _courseData.GetCourseById(id);
        }


        public List<CourseModel> SearchCourses (string title, string teacherName)
        {
            return _courseData.SearchCourses(title, teacherName);
        }
    }
}
