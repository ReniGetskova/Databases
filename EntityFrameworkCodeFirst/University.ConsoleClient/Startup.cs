namespace University.ConsoleClient
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using University.Data;
    using University.Data.Migrations;
    using University.Models;

    public class Startup
    {
        public static void Main()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<UniversityDbContext, Configuration>());

            var db = new UniversityDbContext();

            var student = new Student
            {
                Name = "Pesho",
                FN = "M12345",
                Gender = Gender.Male
            };

            db.Students.Add(student);

            //delete student Pesho
            //var studentsForDelete = db.Students.Where(s => s.Name == "Pesho").ToList();
            //foreach (var item in studentsForDelete)
            //{
            //    db.Students.Remove(item);
            //}

            db.SaveChanges();
           
            Console.WriteLine("Students count: {0}", db.Students.Count());
            Console.WriteLine("Courses count: {0}", db.Courses.Count());
            Console.WriteLine("Authors count: {0}", db.Authors.Count());
            Console.WriteLine("Materials count: {0}", db.Materials.Count());
        }
    }
}
