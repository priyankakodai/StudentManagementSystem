namespace StudentAPI.Models
{
    public class Marks
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int Tamil { get; set; }
        public int English { get; set; }
        public int Maths { get; set; }
        public int Science { get; set; }
        public int Social { get; set; }

        public int TotalMarks { get; set; }
    }
}
