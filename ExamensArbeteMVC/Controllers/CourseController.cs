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

        //[Route("all-courses")]
        public async Task<ViewResult> GetAllCourses()
        {
            var data = await _courseData.GetAllCourses();
            return View(data);
        }
        //[Route("book-details/{id:int:min(1)}", Name = "courseDetailsRoute")]
        public async Task<ViewResult> GetCourseById(int id)
        {
            var data =  await _courseData.GetCourseById(id);
            return View(data);
        }






    }
}