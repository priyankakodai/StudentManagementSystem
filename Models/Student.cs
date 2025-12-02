using System.ComponentModel.DataAnnotations;

<<<<<<< HEAD
namespace StudentWebApp.Models
=======
namespace StudentAPI.Models
>>>>>>> bdb365cb097ab2d431762969e71c4587c82a328c
{
    public class Student
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        public string Class { get; set; }

<<<<<<< HEAD
        public string  Section  { get; set; }
=======
        public string Section { get; set; }
>>>>>>> bdb365cb097ab2d431762969e71c4587c82a328c

        public string ClassTechName { get; set; }

        public string Mobile { get; set; }

    }
}
