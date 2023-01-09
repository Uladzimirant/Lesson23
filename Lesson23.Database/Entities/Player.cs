namespace Lesson23.Database.Entities
{
    public class Player
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public Team Team { get; set; }
        public int Age { get; set; }
        public decimal Salary { get; set; }
    }
}