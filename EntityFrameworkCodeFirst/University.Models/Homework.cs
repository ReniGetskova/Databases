namespace University.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    public class Homework
    {
        public int Id { get; set; }

        [MaxLength(50)]
        public string Content { get; set; }

        public DateTime? TimeSent { get; set; }

        public AllowedFormat? Format { get; set; }

        public Guid? CourseId { get; set; }

        public virtual Course Course { get; set; }

        public int? StudentId { get; set; }

        public virtual Student Student { get; set; }
    }
}
