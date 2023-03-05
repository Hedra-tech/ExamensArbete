using ExamensArbeteMVC.DBcontext;
using ExamensArbeteMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace ExamensArbeteMVC.RepositoryData
{
    public class CourseData : ICourseData
    {
        private readonly StoreContext _context = null;
        public CourseData(StoreContext context)
        {
            _context = context;
        }
        public async Task<List<CourseModel>> GetAllCourses()
        {
            return await _context.Courses
                .Select(c => new CourseModel()
                {
                    Id = c.Id,
                    Title = c.Title,
                    description = c.description,
                    Teacher = c.Teacher,
                    price = c.price,
                    startDate = c.startDate,
                    ImagesPath = c.ImagesPath
                }).ToListAsync();
        }
        //public async Task<CourseModel> GetCourseId(int id)
        //{

        //    return await _context.Courses
        //     .FirstOrDefaultAsync(x => x.Id == id);
        //}

        public async Task<CourseModel> GetCourse(int courseId)
        {
            var courseDTO = _context.Courses.FirstOrDefault(c => c.Id == courseId);

            if (courseDTO == null)
            {
                return null;
            }

            var courseModel = new CourseModel
            {
                Id = courseDTO.Id,
                Title = courseDTO.Title,
                description = courseDTO.description,
                Teacher = courseDTO.Teacher,
                price= courseDTO.price,
                ImagesPath = courseDTO.ImagesPath,
            };

            return courseModel;
        }
        //public async Task<List<CourseModel>> GetOtherCoursesAsync(int count)
        //{
        //    return await _context.Courses
        //        .Select(c => new Model()
        //        {
        //            Id = c.Id,
        //            Title = c.Title,
        //            description = c.description,
        //            Teacher = c.Teacher,
        //            price = c.price,
        //            startDate = c.startDate,
        //            ImagesPath = c.ImagesPath
        //        }).Take(count).ToListAsync();

        //}





    }
}
