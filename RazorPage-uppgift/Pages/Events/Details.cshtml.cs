using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPage_uppgift.Data;
using RazorPage_uppgift.Models;

namespace RazorPage_uppgift.Pages.Events
{
    public class DetailsModel : PageModel
    {
        private readonly RazorPage_uppgift.Data.RazorPage_uppgiftContext _context;

        public DetailsModel(RazorPage_uppgift.Data.RazorPage_uppgiftContext context)
        {
            _context = context;
        }

        public Event Event { get; set; }
        public bool EventIsListed { get; set; }


        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }


            EventIsListed = await _context.JoinedEvents
                .Where(e => e.EventID == id)
                .FirstOrDefaultAsync(a => a.AttendeeID == 1)
                == default ? false : true;

            Event = await _context.Events
                .Include(e => e.Organizer)
                .FirstOrDefaultAsync(m => m.EventID == id);


            if (Event == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
