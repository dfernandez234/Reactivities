using Reactivities.Contracts.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reactivities.Contracts.Activities
{
    public class GetActivityResponse
    {
        public string ActivityId { get; set; }
        public string Title { get; set; } = string.Empty;
        public DateTime Date { get; set; }
        public string Description { get; set; } = string.Empty;
        public string Category { get; set; } = string.Empty;
        public string? City { get; set; }
        public string? Venue { get; set; }
        public string HostUsername { get; set; }
        public bool IsCancelled { get; set; }
        public List<Profile> Attendees { get; set; } = new List<Profile>();
    }
}
