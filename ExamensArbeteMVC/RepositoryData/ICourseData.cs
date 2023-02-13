using ExamensArbeteMVC.Models;

namespace ExamensArbeteMVC.RepositoryData
{
    public interface ICourseData
    {
        Task<List<CourseModel>> GetAllCourses();
        Task<List<CourseModel>> GetCourseById(int id);
    }
}