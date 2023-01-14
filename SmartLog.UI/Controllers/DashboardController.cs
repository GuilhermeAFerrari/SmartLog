using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SmartLog.Application.Interfaces;
using SmartLog.Domain.Entities;
using SmartLog.UI.Models;

namespace SmartLog.UI.Controllers;

public class DashboardController : Controller
{
    private readonly ILogService _logService;
    public DashboardController(ILogService logService)
    {
        _logService = logService;
    }

    [HttpGet]
    public async Task<IActionResult> Index()
    {
        var logs = await _logService.GetLogsAsync();
        var counters = await _logService.GetCountersAsync();
        var result = new DashboardViewModel() { Log = logs, Counters = new Counter() { High = counters.High, Mid = counters.Mid, Low = counters.Low } };
        return View(result);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
