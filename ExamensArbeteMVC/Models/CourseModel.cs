﻿using System.ComponentModel.DataAnnotations;

namespace ExamensArbeteMVC.Models
{
    public class CourseModel
    {
        [Key]

        public int? Id { get; set; }
        public string? Title { get; set; }
        public string? description { get; set; }
        public string? Teacher { get; set; }
        public string? price { get; set; }

        public string? startDate { get; set; }
        public string? ImagesPath { get; set; }

    
    }
    }

