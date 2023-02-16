using ExamensArbeteMVC.Models;

namespace ExamensArbeteMVC.RepositoryData
{
    public interface ICourseData
    {
        Task<List<CourseModel>> GetAllCourses();
        Task<CourseModel> GetCourseById(int id);
    }
}