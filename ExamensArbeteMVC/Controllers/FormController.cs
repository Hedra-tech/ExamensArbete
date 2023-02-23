using ExamensArbeteMVC.Models;
using ExamensArbeteMVC.RepositoryData;
using Microsoft.AspNetCore.Mvc;

namespace ExamensArbeteMVC.Controllers
{
    public class FormController : Controller
    {
        private readonly FormData _courseData = null;
        public FormController(FormData courseData)
        {
            _courseData = courseData;
        }
        public ViewResult ContactForm(bool isSuccess = false, int courseId = 0)
        {
            ViewBag.IsSuccess = isSuccess;
            ViewBag.courseId = courseId;
            return View();
        }
        [HttpPost]
        //I use IactionResult to return any type of return method
        public async Task<IActionResult> ContactForm(ContactFormModel contactFormModel)
        {
            if (ModelState.IsValid)
            {
                //when the id is bigger than 0, then it will redirect us to the form
                int id = await _courseData.ContactForm(contactFormModel);
                if (id > 0)
                {
                    return RedirectToAction(nameof(ContactForm), new { isSuccess = true });
                }
            }
              
            return View();

        }

    }
}