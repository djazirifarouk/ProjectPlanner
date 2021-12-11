namespace ProjectPlanner.Models
{
    public class Project
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Column> Columns { get; set; } = new List<Column>();
    }
}