using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;
using TDBA.Data;

namespace TDBA.Services
{
    public class EventService
    {
        private readonly AppDbContext _context;

        public EventService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<EventModel>> GetAllEvents()
        {
            return await _context.Events.ToListAsync();
        }

        public async Task AddEvent(EventModel newEvent)
        {
            Console.WriteLine($"Adding event: {newEvent.Name}, Age Group: {newEvent.AgeGroup}, Price: {newEvent.PriceRange}, Indoor: {newEvent.IsIndoor}");

            _context.Events.Add(newEvent);
            await _context.SaveChangesAsync();

            Console.WriteLine("Event saved to database.");
        }
    }
}
