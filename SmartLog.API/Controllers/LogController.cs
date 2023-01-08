using Microsoft.AspNetCore.Mvc;
using SmartLog.Domain.Entities;
using SmartLog.Domain.Enum;

namespace SmartLog.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class LogController : ControllerBase
{
    [HttpGet]
    public IEnumerable<Log> Get()
    {
        var logs = new List<Log>()
        {
            new Log() { IdSecondary = Guid.NewGuid(), Level = Level.High, Message = "An critical error with core of system" },
            new Log { IdSecondary = Guid.NewGuid(), Level = Level.High, Message = "An critical error with core of system" },
            new Log { IdSecondary = Guid.NewGuid(), Level = Level.High, Message = "An critical error with core of system" }
        };

        return logs.ToList();
    }
}