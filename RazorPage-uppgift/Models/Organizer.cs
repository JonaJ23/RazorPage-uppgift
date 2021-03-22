using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPage_uppgift.Models
{
    public class Organizer
    {
        public int OrganizerID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public ICollection<Event> Event { get; set; }
    }
}
