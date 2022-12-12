﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reactivities.Domain.Entities
{
    public class ActivityAttendee
    {
        public string AppUserId { get; set; }
        public AppUser AppUser { get; set; }

        public string ActivityId { get; set; }
        public Activity Activity { get; set; }

        public bool IsHost { get; set; }

    }
}
