public class User 
{
    public int Id { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
    public List<Project> Projects { get; set; } = new List<Project>();
}