﻿namespace University.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Course
    {
        private ICollection<Student> students;
        private ICollection<Homework> homeworks;
        private ICollection<Material> materials;

        public Course()
        {
            this.Id = Guid.NewGuid();
            this.students = new HashSet<Student>();
            this.homeworks = new HashSet<Homework>();
            this.materials = new HashSet<Material>();
        }

        public Guid Id { get; set; }

        [Required]
        [MaxLength(20)]
        public string Name { get; set; }

        public string Description { get; set; }

        public virtual ICollection<Student> Students
        {
            get { return this.students; }
            set { this.students = value; }
        }

        public virtual ICollection<Homework> Homeworks
        {
            get { return this.homeworks; }
            set { this.homeworks = value; }
        }

        public virtual ICollection<Material> Materials
        {
            get { return this.materials; }
            set { this.materials = value; }
        }
    }
}
