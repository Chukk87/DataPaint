using DataPaintLibrary.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

[Route("Log")]
public class LogController : Controller
{
    private readonly ILoggerService _loggerService;

    public LogController(ILoggerService logService)
    {
        _loggerService = logService;
    }

    [HttpGet]
    [Route("")]
    public IActionResult Index()
    {
        var logs = _loggerService.GetLogs();
        return View(logs);
    }
}