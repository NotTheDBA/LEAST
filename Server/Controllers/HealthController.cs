using Microsoft.AspNetCore.Mvc;

namespace LEAST.Server.Controllers;
[ApiController]
[Route("[controller]")]
public class HealthController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Healthy", "Unhealthy"
    };

    private static readonly string[] Services = new[]
    {
        "API", "DB", "Service1", "Service2"
    };

    private readonly ILogger<HealthController> _logger;

    public HealthController(ILogger<HealthController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetHealthChecks")]
    public IEnumerable<HealthCheck> Get()
    {

        return Enumerable.Range(0, Services.Length).Select(index => new HealthCheck
        {
            Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            Service = Services[index],
            Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        })
        .ToArray();
    }
}
