using Microsoft.EntityFrameworkCore;

namespace Web_Api_code_First_Demo_many_to_many.Models
{
    public class StudentCourseDbContext:DbContext
    {
        public StudentCourseDbContext(DbContextOptions options)
            :base(options)
        {
                
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
    }
}
