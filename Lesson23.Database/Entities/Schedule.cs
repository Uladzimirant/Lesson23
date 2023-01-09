namespace Lesson23.Database.Entities
{
    public class Schedule
    {
        public int Id { get; set; }
        public Group? Group { get; set; }
        public Team? TeamA { get; set; }
        public Team? TeamB { get; set; }
        public DateTime Time { get; set; }
    }
}