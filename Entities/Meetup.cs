namespace ModsenTestAPI.Entities
{
    public class Meetup
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateTime Date { get; set; }
        public string Place { get; set; } = string.Empty ;
        public string[] Tags { get; set; }
    }
}
