using DataPaintLibrary.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

[Route("SecurityGroups")]
public class SecurityGroupController : Controller
{
    private readonly IAppCollectionService _appCollectionService;
    private readonly ILoggerService _loggerService;
    private readonly ISqlService _sqlService;
    private readonly ISecurityGroupService _securityGroupService;

    public SecurityGroupController(IAppCollectionService appCollectionService, ILoggerService loggerService, ISqlService sqlService, ISecurityGroupService securityGroupService)
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
        var securityGroups = await _appCollectionService.GetSecurityGroups();
        return PartialView("_SecurityGroups", securityGroups);
    }
}
