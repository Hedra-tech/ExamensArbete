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
        public ViewResult GetAllCourses()
        {
            var data = _courseData.GetAllCourses();
            return View(data);
        }

        public ViewResult GetCourseById(int id)
        {
            var data = _courseData.GetCourseById(id);
            return View(data);
        }


        public CourseModel SearchCourses (string title)
        {
            return _courseData.SearchCourses(title);
        }
      
    }
}
