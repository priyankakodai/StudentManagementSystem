<<<<<<< HEAD
﻿using System.ComponentModel.DataAnnotations;

namespace StudentWebApp.Models
{
    public class Marks
    {
        [Key]
        public int Id { get; set; }

        [Key]
        public int StudentId { get; set; }

        public string Name { get; set; }

=======
﻿namespace StudentAPI.Models
{
    public class Marks
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
>>>>>>> bdb365cb097ab2d431762969e71c4587c82a328c
        public int Tamil { get; set; }
        public int English { get; set; }
        public int Maths { get; set; }
        public int Science { get; set; }
        public int Social { get; set; }

<<<<<<< HEAD
       
        public int? Total { get; set; }
=======
        public int TotalMarks { get; set; }
>>>>>>> bdb365cb097ab2d431762969e71c4587c82a328c
    }
}
