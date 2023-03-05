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
                description= "Certificate course in Python is a short-term course, Though there is no specified eligibility criterion to seek admission to a Python course, individuals are still expected to have a basic knowledge of computer programming. The course aims to provide basic knowledge and skills of Python language to students. You will get to know about the Python course details, the fee charged, syllabus, job opportunities, and starting salary expected after completing the course.",
                Teacher="John Smith",
                price ="250$",
                startDate="2023-05-08",
                ImagesPath="/Images/Courses/Python.jpg",

            }); ;
            modelBuilder.Entity<CourseDTO>().HasData(new CourseDTO()
            {
                Id = 2,
                Title = "Java",
                description= "This Full Stack Java Developer Course in SkillStream is designed to give you the essence of front-end, middleware, and back-end Java web developer technologies. You will learn to build an end-to-end application, test and deploy code,Learn core computer science concepts from leading industry experts with content structured to ensure industrial relevance, store data using MongoDB, and much more. And you will earn an industry-recognized course completion certificate",
                Teacher="Sarah Johnson",
                price ="299$",
                startDate="2023-05-15",
                ImagesPath="/Images/Courses/Java.jpg",

            }); ;
            modelBuilder.Entity<CourseDTO>().HasData(new CourseDTO()
            {
                Id = 3,
                Title = "JavaScript",
                description= "SkillStream offer JavaScript course for beginners that requires some basic knowledge of HTML and CSS and the students are good to go. The course prepares students to apply as a Junior Web Developer or SDE - 1 role in any prestigious MNCs. The JavaScript from the Beginning Course will got everything covered from scratch and it is quite helpful for those, who don’t have advanced programming or Java skills. JavaScript class cover topics such as  how to code JavaScript, debug JavaScript (i.e. fix problems in JavaScript code), and create interactive websites. JavaScript tutorials ",
                Teacher="Michael Lee",
                price ="299$",
                startDate="2023-05-08",
                ImagesPath="/Images/Courses/JavaScript.jpg",

            }); ;
            modelBuilder.Entity<CourseDTO>().HasData(new CourseDTO()
            {
                Id = 4,
                Title = "C#",
                description= "C# is a powerful backend coding language used for Microsoft web and desktop applications. C# is a C-style language, so you can take C# and learn other languages such as Java, C and C++. This course will get you started with C# and the language styles including object-oriented programming (OOP). As with any programming language, we start with the basics including operators, variables and primitive strings. These concepts are shared across all programming languages, but you learn the specific nuances of the basics in C#.\r\nAfter you learn the basics, we move on to operators and Boolean logic. These features control the flow of your code, and they can be a source of errors if you don't understand them properly. We cover them in detail, so you understand how to change the flow of your code to dynamically display the right information to your users.",
                Teacher="Emily Davis",
                price ="299$",
                startDate="2023-05-22",
                ImagesPath="/Images/Courses/Csharp.jpg",

            }); ;
            modelBuilder.Entity<CourseDTO>().HasData(new CourseDTO()
            {
                Id = 5,
                Title = "Cloud and DevOps",
                description= "With the necessary prerequisites of software installation ability and some experience in programming and Linux, one can make great strides in their career with the support of DevOps course curriculum. The course is designed to offer deep insights and knowledge into various tools such as Ansible, Puppet, Nagios, Jenkins and Docker. With the adept learning of DevOps course syllabus, a student will be able to become a trained practitioner in the integration and monitoring of software throughout their development cycle. Depending on the duration of the course, it can be divided into a given number of case studies and projects for the complete understanding of the professionals. Several people are seeking DevOps course syllabus today. This makes the DevOps course syllabus quite attractive for budding professionals. ",
                Teacher="David Martinez",
                price ="199$",
                startDate="2023-05-29",
                ImagesPath="/Images/Courses/Devops.jpg",

            }); ;
            modelBuilder.Entity<CourseDTO>().HasData(new CourseDTO()
            {
                Id = 6,
                Title = "Cyber Security",
                description= "This course covers the duties of cybersecurity analysts who are responsible for monitoring and detecting security incidents in information systems and networks, and for executing a proper response to such incidents. The course introduces tools and tactics to manage cybersecurity risks, identify various types of common threats, evaluate the organization's security, collect and analyze cybersecurity intelligence, and handle incidents as they occur. Ultimately, the course promotes a comprehensive approach to security aimed toward those on the front lines of defense.",
                Teacher="Samantha Wong",
                price ="199$",
                startDate="2023-05-08",
                ImagesPath="/Images/Courses/CyberS.jpg",

            }); ;
            modelBuilder.Entity<CourseDTO>().HasData(new CourseDTO()
            {
                Id = 7,
                Title = "UI/UX design",
                description= "The UI/UX Design Specialization brings a design-centric approach to user interface and user experience design, and offers practical, skill-based instruction centered around a visual communications perspective, rather than on one focused on marketing or programming alone. In this courses, you will summarize and demonstrate all stages of the UI/UX development process, from user research to defining a project’s strategy, scope, and information architecture, to developing sitemaps and wireframes. You’ll learn current best practices and conventions in UX design and apply them to create effective and compelling screen-based experiences for websites or apps.\r\n\r\nUser interface and user experience design is a high-demand field, but the skills and knowledge you will learn in this Specialization are applicable to a wide variety of careers, from marketing to web design to human-computer interaction. ",
                Teacher="Robert Kim",
                price ="250$",
                startDate="2023-05-22",
                ImagesPath="/Images/Courses/UIux.jpg",

            }); ;
            modelBuilder.Entity<CourseDTO>().HasData(new CourseDTO()
            {
                Id = 8,
                Title = "SQL Server",
                description= "In this course you will be able to : Learn about SQL – Structured Query Language\r\n Build database using Data Definition Language Statements Perform basic CRUD operations using Data\r\nManipulation Language statements like Insert, Update and Delete Write and call Stored Procedures and Functions stored in database. Write and manage database triggers, cursors and Index.",
                Teacher="Lisa Patel",
                price ="199$",
                startDate="2023-05-29",
                ImagesPath="/Images/Courses/SqlServer.jpg",

            }); ;

        }

    }
}


