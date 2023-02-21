using ExamensArbeteMVC.DBcontext;
using ExamensArbeteMVC.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExamensArbeteMVC.DBcontext;

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
                    Title = c.Title,
                    description = c.description,
                    Teacher = c.Teacher,
                    price = c.price,
                    startDate = c.startDate,
                    ImagesPath = c.ImagesPath
                }).ToListAsync();
        }

        public async Task<CourseModel> GetCourseById(int id)
        {
            
            return await _context.Courses
                .Where(x => x.Id == id)
                .FirstOrDefaultAsync();
        }


        //.Select(c => new CourseModel()
        //{
        //    Title = c.Title,
        //        description = c.description,
        //        Teacher = c.Teacher,
        //        price = c.price,
        //        startDate = c.startDate,
        //        ImagesPath = c.ImagesPath
        //    })










    }
}
