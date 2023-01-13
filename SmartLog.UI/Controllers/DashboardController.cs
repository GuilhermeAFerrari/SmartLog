using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SmartLog.Application.Interfaces;
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
        return View(logs);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
