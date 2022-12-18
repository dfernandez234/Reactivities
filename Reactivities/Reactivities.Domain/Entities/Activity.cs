using System.ComponentModel.DataAnnotations;

namespace Reactivities.Domain.Entities;
public class Activity
{
    [Key]
    public string ActivityId { get; set; } = "";
    public string Title { get; set; } = string.Empty;
    public DateTime Date { get; set; }
    public string Description { get; set; } = string.Empty;
    public string Category { get; set; } = string.Empty;
    public string? City { get; set; }
    public string? Venue { get; set; }  
    public bool IsCancelled { get; set; }
    public List<ActivityAttendee> Attendees { get; set;} = new List<ActivityAttendee>();
    public List<Comment> Comments { get; set; } = new List<Comment>();
}