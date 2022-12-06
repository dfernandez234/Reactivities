namespace Reactivities.Domain.Entities.Activity;
public class Activity
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Title { get; set; } = string.Empty;
    public DateTime Date { get; set; }
    public string Description { get; set; } = string.Empty;
    public string Category { get; set; } = string.Empty;
    public string? City { get; set; }
    public string? Venue { get; set; }
}