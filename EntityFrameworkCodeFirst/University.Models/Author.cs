namespace University.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    public class Author
    {
        private ICollection<Material> materials;

        public Author()
        {
            this.materials = new HashSet<Material>();
        }
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        public int Age { get; set; }

        public Gender Gender { get; set; }

        public virtual ICollection<Material> Materials
        {
            get { return this.materials; }
            set { this.materials = value; }
        }
    }
}
