using Microsoft.AspNetCore.Mvc;
using SmartLog.Application.DTOs;
using SmartLog.Application.Interfaces;
using SmartLog.Domain.Entities;

namespace SmartLog.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class LogController : ControllerBase
{
    private readonly ILogService _logService;

    public LogController(ILogService logRepository)
    {
        _logService = logRepository;
    }

    [HttpGet]
    public async Task<IEnumerable<LogDTO>> Get()
    {
        return await _logService.GetLogsAsync();
    }

    [HttpGet("{id:Guid}", Name = "GetLog")]
    public async Task<ActionResult<LogDTO>> Get(Guid id)
    {
        var category = await _logService.GetLogAsync(id);

        if (category is null)
            return NoContent();

        return Ok(category);
    }

    [HttpPost]
    public async Task<ActionResult> Post([FromBody] LogDTO log)
    {
        if (log is null)
            return BadRequest("Invalid data");

        await _logService.AddLogAsync(log);

        return new CreatedAtRouteResult("GetLog", new { id = log.Id_secondary }, log);
    }
}