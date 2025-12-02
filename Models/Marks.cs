using System.ComponentModel.DataAnnotations;

namespace StudentWebApp.Models
{
    public class Marks
    {
        [Key]
        public int Id { get; set; }

        [Key]
        public int StudentId { get; set; }

        public string Name { get; set; }

        public int Tamil { get; set; }
        public int English { get; set; }
        public int Maths { get; set; }
        public int Science { get; set; }
        public int Social { get; set; }

       
        public int? Total { get; set; }
    }
}
