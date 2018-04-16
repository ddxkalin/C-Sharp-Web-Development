namespace ManyToManyRelation
{
    using System;
    using Data;
    using Models;

    public class Startup
    {
        public static void Main()
        {
            using (var context = new StudentsCoursesDbContext())
            {
                InitializeDatabase(context);
                Seed(context);
            }
        }

        private static void Seed(StudentsCoursesDbContext context)
        {
            var student1 = new Student { Name = "Pesho" };
            var student2 = new Student { Name = "Ivan" };
            var student3 = new Student { Name = "Maria" };

            var course1 = new Course { Name = "C# Web Development Basics" };
            var course2 = new Course { Name = "C# OOP Advanced" };

            student1.StudentsCourses.Add(new StudentCourse { Course = course1 });
            student1.StudentsCourses.Add(new StudentCourse { Course = course2 });
            student2.StudentsCourses.Add(new StudentCourse { Course = course1 });
            student3.StudentsCourses.Add(new StudentCourse { Course = course2 });

            context.Students.Add(student1);
            context.Students.Add(student2);
            context.Students.Add(student3);

            context.SaveChanges();

            Console.WriteLine("Database StudentsDb created.");
        }

        private static void InitializeDatabase(StudentsCoursesDbContext context)
        {
            Console.WriteLine("Initializing database...");

            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();
        }
    }
}