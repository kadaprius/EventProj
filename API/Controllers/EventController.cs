using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EventController : ControllerBase
{
    [HttpGet]
    public string GetEvents()
    {
        return "Events";
    }
    [HttpGet("{id}")]
    public string GetEventById(int id)
    {
        return "Event ID";
    }
}