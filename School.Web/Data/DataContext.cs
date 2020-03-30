namespace School.Web.Data
{
    using Microsoft.EntityFrameworkCore;
    using School.Web.Data.Entities;

    public class DataContext : DbContext
    {
        public DbSet<Gender> Genders { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

    }
}
