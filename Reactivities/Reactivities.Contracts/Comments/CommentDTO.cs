using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reactivities.Contracts.Comments
{
    public class CommentDTO
    {
        public string Id { get; set; }
        public DateTime CreatedAAt { get; set; }
        public string Body { get; set; }
        public string Username { get; set; }
        public string DisplayName { get; set; }
        public string Image { get; set; }
    }
}
