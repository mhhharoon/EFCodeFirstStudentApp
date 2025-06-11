using System.Data.Entity;

namespace EFCodeFirstStudentApp
{
    public class StudentContext : DbContext
    {
        // Call the base constructor and provide a name for the connection string
        public StudentContext() : base("StudentDBConnection") { }

        // This will be used to create a table named "Students"
        public DbSet<Student> Students { get; set; }
    }
}
