using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StackOverflow.Data;

namespace StackOverflow.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PostsController : ControllerBase
{
    private readonly AppDbContext _context;

    public PostsController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public IActionResult Get()
    {
        var posts = _context.Posts
            .OrderByDescending(row => row.ClosedDate)
            .Select(i => new
            {
                i.Id,
                i.Title,
            
            })
            .Skip(0)
            .Take(20);

        return Ok(posts);
    }
}
