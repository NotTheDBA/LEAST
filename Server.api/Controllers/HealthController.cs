using Microsoft.AspNetCore.Mvc;
using Server.Clinic;

namespace LEAST.Server.api.Controllers;
[ApiController]
[Route("[controller]")]
public class HealthController(ILogger<HealthController> logger) : ControllerBase
{
    private readonly static string[] Summaries =
    [
        "Healthy", "Unhealthy"
    ];

    private readonly static string[] Services =
    [
        "API", "DB", "Service1", "Service2"
    ];

    private readonly ILogger<HealthController> _logger = logger;

    [HttpGet(Name = "GetHealthChecks")]
    public IEnumerable<HealthCheck> Get()
    {
        _logger.LogInformation("Health Checks");

        return Enumerable.Range(0, Services.Length).Select(index => new HealthCheck
        {
            Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            Service = Services[index],
            Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        })
        .ToArray();
    }
}
