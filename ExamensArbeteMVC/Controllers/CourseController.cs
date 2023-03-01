using ExamensArbeteMVC.Models;
using ExamensArbeteMVC.RepositoryData;
using Microsoft.AspNetCore.Mvc;

namespace ExamensArbeteMVC.Controllers
{
    public class CourseController : Controller
    {


        private readonly ICourseData _courseData = null;

        public CourseController(ICourseData courseData)
        {
            _courseData = courseData;
        }

        [Route("all-courses")]
        public async Task<ViewResult> GetAllCourses()
        {
            var data = await _courseData.GetAllCourses();
            return View(data);
        }
     
        public async Task<IActionResult> GetCourseId(int id)
        {
            var course = await _courseData.GetCourse(id);

            if (course == null)
            {
                return NotFound();
            }

            return View(course);
        }






    }
}