using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reactivities.Domain.Entities
{
    public class UserFollowing
    {
        public string ObserverId { get; set; }
        public AppUser Oberver { get; set; }
        public string TargetId { get; set; }
        public AppUser Target { get; set; }
    }
}
