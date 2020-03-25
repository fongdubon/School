namespace School.Web.Data
{
    using Microsoft.EntityFrameworkCore;
    using School.Web.Data.Entities;

    public class DataContext : DbContext
    {
        public DbSet<Gender> Genders { get; set; }
        public DbSet<Student> Students { get; set; }
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

    }
}
