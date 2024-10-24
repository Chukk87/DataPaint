using DataPaintLibrary.Services.Classes;
using DataPaintLibrary.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

[Route("Log")]
public class LogController : Controller
{
    private readonly ILoggerService _loggerService;

    public LogController(ILoggerService loggerService)
    {
        _loggerService = loggerService;
    }

    [HttpGet]
    [Route("LoadLogs")]
    public IActionResult LoadLogs()
    {
        var logs = _loggerService.GetLogs();
        return PartialView("_Logs", logs);
    }
}