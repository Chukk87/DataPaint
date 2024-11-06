using DataPaintLibrary.Classes.Input;
using DataPaintLibrary.Services.Classes;
using DataPaintLibrary.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Threading.Tasks;

[Route("SecurityGroups")]
public class SecurityGroupsController : Controller
{
    private readonly IAppCacheService _appCacheService;
    private readonly IAppCollectionService _appCollectionService;
    private readonly ILoggerService _loggerService;
    private readonly ISqlService _sqlService;
    private readonly ISecurityGroupService _securityGroupService;

    public SecurityGroupsController(IAppCacheService appCacheService, IAppCollectionService appCollectionService, ILoggerService loggerService, 
        ISqlService sqlService, ISecurityGroupService securityGroupService)
    {
        _appCacheService = appCacheService;
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
            ViewBag.Users = await _appCollectionService.GetAllUsersAsync();

            _appCacheService.AddSecurityGroup(await _appCollectionService.GetSecurityGroupsAsync());
            return PartialView("_SecurityGroups", _appCacheService.GetSecurityGroups());
        }
        catch (Exception ex)
        {
            _loggerService.RecordException(ex, nameof(LoadSecurityGroups), "Error occurred while loading security groups.");
            return StatusCode(500, "Internal server error");
        }
    }

    [HttpGet]
    [Route("GetBaseUserDetails/{groupId}")]
    public async Task<IActionResult> GetBaseUserDetails(Guid groupId)
    {
        var group = _appCacheService.GetSecurityGroups().Find(x => x.Id == groupId);
        var users = _securityGroupService.GetUsersForSecurityGroup(group, await _appCollectionService.GetAllUsersAsync());

        var result = users.Select(user => new { user.Id, FullName = user.FullName }).ToList();

        return Json(result);
    }

    [HttpGet]
    [Route("GetAdminUserDetails/{groupId}")]
    public async Task<IActionResult> GetAdminUserDetails(Guid groupId)
    {
        var group = _appCacheService.GetSecurityGroups().Find(x => x.Id == groupId);
        var adminUsers = _securityGroupService.GetAdminUsersForSecurityGroup(group, await _appCollectionService.GetAllUsersAsync());

        var result = adminUsers.Select(admin => new { admin.Id, FullName = admin.FullName }).ToList();

        return Json(result);
    }

    [HttpGet]
    [Route("GetSecurityDetails/{groupId}")]
    public IActionResult GetSecurityDetails(Guid groupId)
    {
        try
        {
            var securityGroup = _appCacheService.GetSecurityGroups().FirstOrDefault(x => x.Id == groupId);
            if (securityGroup == null)
            {
                return NotFound("Security group not found.");
            }

            return Json(new
            {
                SecurityType = securityGroup.SecurityType.ToString(),
                AuthorizationType = securityGroup.AuthorisationType.ToString(),
                VisibleToAll = securityGroup.VisibleToAll
            });
        }
        catch (Exception ex)
        {
            _loggerService.RecordException(ex, nameof(GetSecurityDetails), "Error occurred while retrieving security group details.");
            return StatusCode(500, "Internal server error");
        }
    }
}