using Microsoft.AspNetCore.Mvc;
using SmartLog.Domain.Entities;
using SmartLog.Domain.Enum;
using SmartLog.Domain.Interfaces;

namespace SmartLog.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class LogController : ControllerBase
{
    private readonly ILogRepository _logRepository;

    public LogController(ILogRepository logRepository)
    {
        _logRepository = logRepository;
    }

    [HttpGet]
    public async Task<IEnumerable<Log>> Get()
    {
        return await _logRepository.GetLogsAsync();
    }
}