using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using ExamensArbeteMVC.Models;

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

    }
    
    }

