using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;


namespace ExamensArbeteMVC.DBcontext
{

    public class StoreContext : IdentityDbContext

    {
        public StoreContext(DbContextOptions<StoreContext> options)
            : base(options)
        {

        }
        public DbSet<Form> Contacts { get; set; }
        public DbSet<CourseDTO> Courses { get; set; }

       
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<CourseDTO>().HasData(new CourseDTO()
            {
                Id = 1,
                Title = "Python",
                description= "Begginers",
                Teacher="Anna Peterson",
                price ="120$",
                startDate="2023-05-05",
                ImagesPath="/Images/Courses/Course1.jpg",

            }); ;
            modelBuilder.Entity<CourseDTO>().HasData(new CourseDTO()
            {
                Id = 2,
                Title = "Java",
                description= "Begginers",
                Teacher="Anna Peterson",
                price ="120$",
                startDate="2023-05-05",
                ImagesPath="/Images/Courses/Course1.jpg",

            }); ;
            modelBuilder.Entity<CourseDTO>().HasData(new CourseDTO()
            {
                Id = 3,
                Title = "JavaScript",
                description= "Begginers",
                Teacher="Anna Peterson",
                price ="120$",
                startDate="2023-05-05",
                ImagesPath="/Images/Courses/Course2.jpg",

            }); ;
            modelBuilder.Entity<CourseDTO>().HasData(new CourseDTO()
            {
                Id = 4,
                Title = "C#",
                description= "Begginers",
                Teacher="Anna Peterson",
                price ="120$",
                startDate="2023-05-05",
                ImagesPath="/Images/Courses/Course2.jpg",

            }); ;
            modelBuilder.Entity<CourseDTO>().HasData(new CourseDTO()
            {
                Id = 5,
                Title = "Python",
                description= "Begginers",
                Teacher="Anna Peterson",
                price ="120$",
                startDate="2023-05-05",
                ImagesPath="/Images/Courses/Course1.jpg",

            }); ;
            modelBuilder.Entity<CourseDTO>().HasData(new CourseDTO()
            {
                Id = 6,
                Title = "Java",
                description= "Begginers",
                Teacher="Anna Peterson",
                price ="120$",
                startDate="2023-05-05",
                ImagesPath="/Images/Courses/Course1.jpg",

            }); ;
            modelBuilder.Entity<CourseDTO>().HasData(new CourseDTO()
            {
                Id = 7,
                Title = "JavaScript",
                description= "Begginers",
                Teacher="Anna Peterson",
                price ="120$",
                startDate="2023-05-05",
                ImagesPath="/Images/Courses/Course2.jpg",

            }); ;
            modelBuilder.Entity<CourseDTO>().HasData(new CourseDTO()
            {
                Id = 8,
                Title = "C#",
                description= "Begginers",
                Teacher="Anna Peterson",
                price ="120$",
                startDate="2023-05-05",
                ImagesPath="/Images/Courses/Course2.jpg",

            }); ;

        }

    }
}


