using ExamensArbeteMVC.Models;

namespace ExamensArbeteMVC.RepositoryData
{
    public interface IFormData
    {
        Task<int> ContactForm(ContactFormModel model);
    }
}