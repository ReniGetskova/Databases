namespace University.Data
{
    using System.Data.Entity;
    using University.Models;

    public class UniversityDbContext : DbContext
    {
        public UniversityDbContext()
            : base("UniversityDatabase")
        {    
        }

        public virtual IDbSet<Student> Students { get; set; }

        public virtual IDbSet<Course> Courses { get; set; }

        public virtual IDbSet<Homework> Homeworks { get; set; }

        public virtual IDbSet<Material> Materials { get; set; }

        public virtual IDbSet<Author> Authors { get; set; }
    }
}
