using Microsoft.AspNetCore.Mvc;

namespace Ec2Test;

[Route("api/health")]
[ApiController]
public class HealthController
{
    [HttpGet]
    public string Health()
    {
        return Environment.MachineName;
    }
}