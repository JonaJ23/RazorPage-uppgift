using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPage_uppgift.Models
{
    public class Attendee
    {
        public int AttendeeID { get; set; } // PK
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public ICollection<Event> Event { get; set; }
    }
}
