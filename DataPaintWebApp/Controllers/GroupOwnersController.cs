using Microsoft.AspNetCore.Mvc;
using DataPaintLibrary.Services.Interfaces;
using DataPaintLibrary.Classes;
using System.Threading.Tasks;
using System;

[Route("GroupOwners")]
public class GroupOwnersController : Controller
{
    private readonly IAppCollectionService _appCollectionService;
    private readonly ISqlService _sqlService;

    public GroupOwnersController(IAppCollectionService appCollectionService, ISqlService sqlService)
    {
        _appCollectionService = appCollectionService;
        _sqlService = sqlService;
    }

    [HttpGet]
    [Route("LoadGroupOwners")]
    public async Task<IActionResult> LoadGroupOwners()
    {
        var ownerGroups = await _appCollectionService.GetAllOwnerGroupsAsync();
        return PartialView("_GroupOwners", ownerGroups);
    }

    [HttpGet]
    [Route("GetGroupDetails")]
    public async Task<IActionResult> GetGroupDetails(int id)
    {
        var ownerGroup = await _appCollectionService.GetOwnerGroupByIdAsync(id); 

        if (ownerGroup != null)
        {
            return Json(new
            {
                name = ownerGroup.Name,
                email = ownerGroup.ContactEmail,
                phone = ownerGroup.PhoneNumber
            });
        }
        return NotFound();
    }

    [HttpPost]
    [Route("AddOwnerGroup")]
    public async Task<IActionResult> CreateOwnerGroup([FromBody] OwnerGroup ownerGroup)
    {
        await _sqlService.CreateOwnerGroupAsync(ownerGroup);
        return Json(new { success = true });
    }

    [HttpPost]
    [Route("UpdateOwnerGroup")]
    public async Task<IActionResult> UpdateOwnerGroup([FromBody] OwnerGroup ownerGroup)
    {
        try
        {
            await _sqlService.UpdateOwnerGroupAsync(ownerGroup);
            return Json(new { success = true });
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { error = ex.Message });
        }
    }

    [HttpPost]
    [Route("DeleteOwnerGroup")]
    public async Task<IActionResult> DeleteOwnerGroup([FromBody] OwnerGroup ownerGroup)
    {
        await _sqlService.DeleteOwnerGroupAsync(ownerGroup);

        return Json(new { success = true });
    }
}