using System.ComponentModel.DataAnnotations;

namespace StudentWebApp.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        public string Class { get; set; }

        public string  Section  { get; set; }

        public string ClassTechName { get; set; }

        public string Mobile { get; set; }

    }
}
