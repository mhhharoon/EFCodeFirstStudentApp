using System.ComponentModel.DataAnnotations;

namespace EFCodeFirstStudentApp
{
    public class Student
    {
        [Key] // Marks this property as the Primary Key
        public int StudentId { get; set; }
        public string Name { get; set; }
        public string Major { get; set; }
    }
}
