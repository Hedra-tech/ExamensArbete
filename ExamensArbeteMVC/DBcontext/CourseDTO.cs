using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamensArbeteMVC.DBcontext
{
    public class CourseDTO
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? description { get; set; }
        public string? Teacher { get; set; }
        public string? price { get; set; }
        public string? startDate { get; set; }
        public string ImagesPath { get; set; }
    }
}
