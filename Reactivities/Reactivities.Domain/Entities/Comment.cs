using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reactivities.Domain.Entities
{
    public class Comment
    {
        public string Id { get; set; } = Guid.NewGuid().ToString(); 
        public string Body { get; set; }
        public AppUser Author { get; set; }
        public Activity Activity { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
