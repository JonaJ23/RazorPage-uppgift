using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPage_uppgift.Models
{
    public class Event
    {
        public int EventID { get; set; } // PK
        public Organizer Organizer { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public string Address { get; set; }
        public bool SpotsAvailable { get; set; }
        public ICollection<Attendee> Attendees { get; set; }
    }
}
