using Core.Entities;
using Core.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data;

public class EventsRepository : IEventsRepository
{
    private readonly EventsContext _context;
    
    public EventsRepository(EventsContext context)
    {
        _context = context;
    }

    public async Task<Event> GetProductByIdAsync(int id)
    {
         return await _context.Events.FirstOrDefaultAsync(x => x.Id == id);
    }

    public async Task<IReadOnlyList<Event>> GetProductsAsync()
    {
        return await _context.Events.ToListAsync();
    }
}