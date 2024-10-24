using DataPaintLibrary.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

[Route("SecurityGroups")]
public class SecurityGroupsController : Controller
{
    private readonly IAppCollectionService _appCollectionService;
    private readonly ILoggerService _loggerService;
    private readonly ISqlService _sqlService;
    private readonly ISecurityGroupService _securityGroupService;

    public SecurityGroupsController(IAppCollectionService appCollectionService, ILoggerService loggerService, ISqlService sqlService, ISecurityGroupService securityGroupService)
    {
        _appCollectionService = appCollectionService;
        _loggerService = loggerService;
        _sqlService = sqlService;
        _securityGroupService = securityGroupService;
    }

    [HttpGet]
    [Route("LoadSecurityGroups")]
    public async Task<IActionResult> LoadSecurityGroups()
    {
        try
        {
            var securityGroups = await _appCollectionService.GetSecurityGroups();
            return PartialView("_SecurityGroups", securityGroups);
        }
        catch (Exception ex)
        {
            _loggerService.RecordException(ex, nameof(LoadSecurityGroups), "Error occurred while loading security groups.");
            return StatusCode(500, "Internal server error");
        }
    }
}
