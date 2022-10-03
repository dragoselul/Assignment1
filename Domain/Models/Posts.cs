namespace Domain.Models;

public class Posts
{
    public long Id { get; set; }
    public string Title { get; set; }
    public string Body { get; set; }
    public string Comments { get; set; }
    public int upDownVote { get; set; }
}