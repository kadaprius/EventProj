using Core.Entities;

namespace Core.Interfaces;

public interface IEventsRepository
{
    Task<Event> GetProductByIdAsync(int id);
    Task<IReadOnlyList<Event>> GetProductsAsync();
}