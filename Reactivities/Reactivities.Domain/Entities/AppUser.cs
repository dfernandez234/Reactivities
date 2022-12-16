using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Reactivities.Domain.Entities
{
    public class AppUser : IdentityUser
    {
        public string DisplayName { get; set; }
        public string? Bio { get; set; }
        public List<ActivityAttendee> Activities { get; set; } = new List<ActivityAttendee>();

        public List<Photo> Photos { get; set; } = new List<Photo>();
    }
}
