namespace Lesson23.Database.Entities
{
    public class Team
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Coach Coach { get; set; }
        public Group? Group { get; set; }
        public int Rate { get; set; }

    }
}