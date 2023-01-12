using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SmartLog.UI.Models;

namespace SmartLog.UI.Controllers;

public class DashboardController : Controller
{
    public IActionResult Index()
    {
        // TODO: Consultar API Back-end Rota: Get All
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
