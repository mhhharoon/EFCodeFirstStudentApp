using System;

namespace EFCodeFirstStudentApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new StudentContext())
            {
                // Create a new student object
                var student = new Student
                {
                    Name = "John Doe",
                    Major = "Computer Science"
                };

                // Add the student to the database
                context.Students.Add(student);
                context.SaveChanges();

                Console.WriteLine("Student added successfully!");
            }

            Console.ReadLine();
        }
    }
}
