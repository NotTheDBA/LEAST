namespace Server.Clinic;

public class HealthCheck
{
    public DateOnly Date { get; set; }

    public string? Service { get; set; }

    public string? Summary { get; set; }
}
