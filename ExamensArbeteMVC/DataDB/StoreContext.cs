using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace ExamensArbeteMVC.DataDB
{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions<StoreContext> options)
            : base(options)
        {

        }
        public DbSet<Form> Contacts { get; set; }
       

       
    }
}
