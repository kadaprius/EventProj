using Core.Entities;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EventController : ControllerBase
{
    private readonly IEventsRepository _repo;

    public EventController(IEventsRepository repo)
    {
        _repo = repo;
    }

    [HttpGet]
    public async Task<ActionResult<List<Event>>> GetEvents()
    {
        var events = await _repo.GetProductsAsync();

        return Ok(events);
        
    }
    [HttpGet("{id}")]
    public async Task<ActionResult<Event>> GetEventsById(int id)
    {
        return await _repo.GetProductByIdAsync(id);
    }
}