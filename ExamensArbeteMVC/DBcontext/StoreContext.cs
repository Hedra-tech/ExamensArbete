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
                Teacher="John Smith",
                price ="250$",
                startDate="2023-05-08",
                ImagesPath="/Images/Courses/Python.jpg",

            }); ;
            modelBuilder.Entity<CourseDTO>().HasData(new CourseDTO()
            {
                Id = 2,
                Title = "Java",
                description= "Begginers",
                Teacher="Sarah Johnson",
                price ="299$",
                startDate="2023-05-15",
                ImagesPath="/Images/Courses/Java.jpg",

            }); ;
            modelBuilder.Entity<CourseDTO>().HasData(new CourseDTO()
            {
                Id = 3,
                Title = "JavaScript",
                description= "Begginers",
                Teacher="Michael Lee",
                price ="299$",
                startDate="2023-05-08",
                ImagesPath="/Images/Courses/JavaScript.jpg",

            }); ;
            modelBuilder.Entity<CourseDTO>().HasData(new CourseDTO()
            {
                Id = 4,
                Title = "C#",
                description= "Begginers",
                Teacher="Emily Davis",
                price ="299$",
                startDate="2023-05-22",
                ImagesPath="/Images/Courses/Csharp.jpg",

            }); ;
            modelBuilder.Entity<CourseDTO>().HasData(new CourseDTO()
            {
                Id = 5,
                Title = "Cloud and DevOps",
                description= "Begginers",
                Teacher="David Martinez",
                price ="199$",
                startDate="2023-05-29",
                ImagesPath="/Images/Courses/Devops.jpg",

            }); ;
            modelBuilder.Entity<CourseDTO>().HasData(new CourseDTO()
            {
                Id = 6,
                Title = "Cyber Security",
                description= "Begginers",
                Teacher="Samantha Wong",
                price ="199$",
                startDate="2023-05-08",
                ImagesPath="/Images/Courses/CyberS.jpg",

            }); ;
            modelBuilder.Entity<CourseDTO>().HasData(new CourseDTO()
            {
                Id = 7,
                Title = "UI/UX design",
                description= "Begginers",
                Teacher="Robert Kim",
                price ="250$",
                startDate="2023-05-22",
                ImagesPath="/Images/Courses/UIux.jpg",

            }); ;
            modelBuilder.Entity<CourseDTO>().HasData(new CourseDTO()
            {
                Id = 8,
                Title = "SQL Server",
                description= "Begginers",
                Teacher="Lisa Patel",
                price ="199$",
                startDate="2023-05-29",
                ImagesPath="/Images/Courses/SqlServer.jpg",

            }); ;

        }

    }
}


