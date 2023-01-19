using ExamensArbeteMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace ExamensArbeteMVC.Controllers
{
    public class FormController : Controller
    {
        public ViewResult ContactForm()
        {
            return View();
        }
        [HttpPost]
        public ViewResult ContactForm (ContactFormModel contactFormModel)
        {
            return View();
        }
    }
}
