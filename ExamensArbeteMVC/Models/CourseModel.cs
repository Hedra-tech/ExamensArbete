namespace ExamensArbeteMVC.Models
{
    public class CourseModel
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? description { get; set; }
        public string? Teacher { get; set; }
        public string? price { get; set; }

        public string? startDate { get; set; }
        public string? ImagesPath { get; set; }

        internal object FirstOrDefaultAsync()
        {
            throw new NotImplementedException();
        }
    }
    }

