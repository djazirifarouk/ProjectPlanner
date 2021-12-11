namespace ProjectPlanner.Models
{
    public class Ticket
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Priority { get; set; }
        public DateTime DueDate { get; set; }
        public List<Tag> Tags { get; set; } = new List<Tag>();
        public List<Item> Checklist { get; set; } = new List<Item>();
    }
}