namespace University.Data.Migrations
{
    using System.Data.Entity.Migrations;
    using University.Models;

    public sealed class Configuration : DbMigrationsConfiguration<UniversityDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
            ContextKey = "University.Data.UniversityDbContext";
        }

        protected override void Seed(UniversityDbContext context)
        {
            context.Students.AddOrUpdate(s => s.FN,
            new Student
            {
                Name = "Test student",
                FN = "M98765",
                Gender = Gender.Female
            });

            context.Courses.AddOrUpdate(c => c.Name,
            new Course
            {
                Name = "C#"
            });

            context.Authors.AddOrUpdate(a => a.Name,
                new Author
                {
                    Name = "Test author"
                });

            context.Materials.AddOrUpdate(m => m.Title,
                new Material
                {
                    Title = "Data structures"
                });
        }
    }
}
